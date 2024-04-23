using BUS;
using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class SubViewManageCategory : Form
    {
        Category[] categories;
        Category currentCategory;
        bool CategoryUpddatable = false;

        public SubViewManageCategory()
        {
            InitializeComponent();
            InititalizeDataset();
        }

        private void InititalizeDataset()
        {
            categories = Category.GetCategories();
        }







        #region Fill
        private void FillFirstClassCategory()
        {
            panel_firstClassCategory.Controls.Clear();
            foreach (Category category in categories)
            {
                panel_firstClassCategory.Controls.Add(GenerateCategory(category));
            }
        }
        private void FillCategroryLevel1(Category[] categories)
        {
            comboBox_level1.Items.Clear();
            foreach (Category category in categories)
            {
                comboBox_level1.Items.Add(category.CategoryName);
            }

        }
        private void FillCategroryLevel2(Category[] categories)
        {
            comboBox_level2.Items.Clear();
            comboBox_level2.Text = string.Empty;
            foreach (Category category in categories)
            {
                comboBox_level2.Items.Add(category.CategoryName);
            }

        }
        private void FillCategroryLevel3(Category[] categories)
        {                                     
            comboBox_level3.Items.Clear();
            comboBox_level3.Text = string.Empty;
            foreach (Category category in categories)
            {
                comboBox_level3.Items.Add(category.CategoryName);
            }

        }

        private void FillAttributeList(Category currentCategory)
        {
            panel_attributes.Controls.Clear();
            foreach (string attribute in currentCategory.AttributeList.Split(','))
            {
                panel_attributes.Controls.Add(GenerateAttribute(attribute));
            }

        }
        private void FillCurrentCategory(Category currentCategory)
        {
            rjTextBox_categoryId.Texts = currentCategory.CategoryId;
            rjTextBox_categoryName.Texts = currentCategory.CategoryName;
            rjTextBox_ancestorId.Texts = currentCategory.AncestorId;
            FillAttributeList(currentCategory);
            if( currentCategory.AncestorId == "0")
            {
                panel_attribute.Controls.Clear();
                comboBox_ancestorName.Text = string.Empty;
                return;
            }
            comboBox_ancestorName.Text = categories.Single(cate => cate.CategoryId == currentCategory.AncestorId).CategoryName;

        }
        private void FillAncestorName()
        {
            comboBox_ancestorName.DataSource = categories.Where(category => category.AncestorId == "0").Select(category => category.CategoryName).ToList(); ;
        }
        #endregion












        #region Event handler
        private void RjButton_deleteAttribute_Click(object sender, EventArgs e)
        {
            CategoryUpddatable = true;
            Button deletedButton = (Button)sender;
            deletedButton.Parent.BringToFront();
            deletedButton.Parent.RecursivelyDispose();
        }
        private void RjButton_deleteCategory_Click(object sender, EventArgs e)
        {
            Category temp = categories.Single(category => category.CategoryId == rjTextBox_categoryId.Texts);
            if (categories.Any(category => category.CategoryId == temp.CategoryId 
                && category.CategoryId != rjTextBox_categoryId.Texts 
                && MessageBox.Show("Do you want delete all the child level category as well","Waring",MessageBoxButtons.OKCancel) == DialogResult.OK))
            {
                foreach(Category ca in FindChildCategory(temp))
                {
                    ca.Delete();
                }
                temp.Delete();
            }
            temp.Delete();
            MessageBox.Show("All category deleted");
            InititalizeDataset();
            SubViewManageCategory_Load(null, null);
            IconButton_refreshDataField_Click(null, null);
        }
        private void SubViewManageCategory_Load(object sender, EventArgs e)
        {
            FillFirstClassCategory();
            FillCategroryLevel1(categories.Where(category => category.AncestorId =="0").ToArray());
            FillAncestorName();
            IconButton_refreshDataField_Click(null, null);
        }
        private void RjButton_update_Click(object sender, EventArgs e)
        {
            
            if (WithoutAttributeCheck())
            {
                MessageBox.Show("Category cannot be updated without attribute");
                return;

            }
            if (MergeAttributeList().Any(attribute => attribute == string.Empty))
            {
                MessageBox.Show("There's any attribute with no definition!");
                return;
            }

            Category newCategory = new Category(new DLL.Category_
            {
                CategoryId = rjTextBox_categoryId.Texts,
                CategoryName = rjTextBox_categoryName.Texts,
                AncestorId = rjTextBox_ancestorId.Texts,
                AttributeList = string.Join(",", MergeAttributeList().ToArray())

            });
            if (comboBox_ancestorName.Text != string.Empty
                && MessageBox.Show("After you updated this category, the parent category attributes'll be deleted, \nAre you sure", "Caution", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                categories.Single(category => category.CategoryId == rjTextBox_ancestorId.Texts).ClearAttribute().Update();
            }
            else if (comboBox_ancestorName.Text == string.Empty
                && MessageBox.Show("If you do not specify a ancestor name, this category'll be in the first class", "Caution", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                newCategory.AncestorId = "0";
            }
            else
            {
                return;
            }
            newCategory.Update();
            MessageBox.Show("Updated succesfully");
            IconButton_refreshDataField_Click(null, null);
            InititalizeDataset();
            SubViewManageCategory_Load(null, null);
        }

        private void RjButton_addCategory_Click(object sender, EventArgs e)
        {
            
            if(rjTextBox_categoryId.Texts != string.Empty)
            {
                MessageBox.Show("Unable to add,This category Id has already existed!");
            }
            if (!VerifyPrompt())
            {
                //Show error and end function;
                MessageBox.Show("duplicated category name!!!!!!");
                return;
            }
            if (WithoutAttributeCheck())
            {
                MessageBox.Show("New category cannot be created without attribute");
                return;

            }
            if (MergeAttributeList().Any(attribute => attribute == string.Empty))
            {                                                                                       
                MessageBox.Show("There's any attribute with no definition!");
                return;
            }
            
            Category newCategory = new Category(new DLL.Category_
            {
                CategoryName = rjTextBox_categoryName.Texts,
                AncestorId = rjTextBox_ancestorId.Texts,
                AttributeList = string.Join(",", MergeAttributeList().ToArray())

            });
            if (comboBox_ancestorName.Text != string.Empty
                && MessageBox.Show("After you added this category, the parent category attributes'll be deleted, \nAre you sure", "Caution", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                categories.Single(category => category.CategoryId == rjTextBox_ancestorId.Texts).ClearAttribute().Update();
            }
            else if (comboBox_ancestorName.Text == string.Empty 
                && MessageBox.Show("If you do not specify a ancestor name, this category'll be in the first class", "Caution",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                newCategory.AncestorId = "0";
            }  else
            {
                return;
            }
            newCategory.Add();
            MessageBox.Show("Add succesfully");
            IconButton_refreshDataField_Click(null, null);
            InititalizeDataset() ;
            SubViewManageCategory_Load(null, null);
        }

        private void IconButton_refreshDataField_Click(object sender, EventArgs e)
        {
            CategoryUpddatable = false;
            rjTextBox_categoryId.Texts = string.Empty;
            rjTextBox_categoryName.Texts = string.Empty;
            rjTextBox_ancestorId.Texts = string.Empty;
            comboBox_ancestorName.Text = string.Empty;
            panel_attributes.Controls.Clear();

        }

        private void RjButton_addAttribute_Click(object sender, EventArgs e)
        {
            CategoryUpddatable = true;
            panel_attributes.Controls.Add(GenerateAttribute(""));
            //label_attributeQuantity.Text = label_attributeQuantity.Text.ToInt(;
        }


        private void ComboBox_level1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Category category = categories.Single(ca => ca.CategoryName == comboBox_level1.SelectedItem.ToString());
            FillCategroryLevel2(FindChildCategory(category));
            FillCurrentCategory(category);

        }
        private void RjButton_category_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            Category category = categories.Single(ca => ca.CategoryName == currentButton.Text.ToString());
            if(category.AncestorId == "0")
            {
                // level 1 category was chosen
                comboBox_level1.Text = string.Empty;
                comboBox_level1.SelectedText = category.CategoryName;
                FillCategroryLevel2(FindChildCategory(category));
            }
            else
            {
                Category dad = FindDadCategoey(category);
                if(dad.AncestorId == "0")
                {
                    // level 2 category was chosen
                    comboBox_level1.Text = string.Empty;
                    comboBox_level1.SelectedText = dad.CategoryName;
                    comboBox_level2.Text = string.Empty;
                    comboBox_level2.SelectedText = category.CategoryName;
                } else
                {
                    // level 3 category was chosen
                    comboBox_level1.Text = string.Empty;
                    comboBox_level1.SelectedText = FindDadCategoey(dad).CategoryName;
                    comboBox_level2.Text = string.Empty;
                    comboBox_level2.SelectedText = dad.CategoryName;
                    comboBox_level3.Text = string.Empty;
                    comboBox_level3.SelectedText = category.CategoryName;
                }
            }
            FillCurrentCategory(category);

        }
        private void ComboBox_level2_SelectedIndexChanged(object sender, EventArgs e)
        {

            Category category = categories.Single(ca => ca.CategoryName == comboBox_level2.SelectedItem.ToString());
            FillCategroryLevel3(FindChildCategory(category));
            FillCurrentCategory(category);

        }

        private void ComboBox_level3_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentCategory = categories.Single(category => category.CategoryName == comboBox_level3.SelectedItem.ToString());
            FillCurrentCategory(currentCategory);
        }

        private void ComboBox_ancestorName_SelectedIndexChanged(object sender, EventArgs e)
        {
            rjTextBox_ancestorId.Texts = categories.Single(category => category.CategoryName == comboBox_ancestorName.SelectedItem.ToString()).CategoryId;
            if(comboBox_ancestorName.Text == rjTextBox_categoryName.Texts)
            {
                comboBox_ancestorName.Text = string.Empty;
                rjTextBox_ancestorId.Texts = "0";
            }
            CategoryUpddatable = true;
        }
        private void RjTextBox_categoryName__TextChanged(object sender, System.EventArgs e)
        {
            CategoryUpddatable = true;
        }
        private void RjTextBox_attriibuteName__TextChanged(object sender, EventArgs e)
        {
            CategoryUpddatable = true;
        }

        #endregion









        #region Supporting Function

        private IEnumerable<string> MergeAttributeList()
        {
            foreach( RJTextBox rJTextBox in panel_attributes.Controls.Find("rjTextBox_attriibuteName", true))
            {
                yield return rJTextBox.Texts;        
            }
        }
        private bool WithoutAttributeCheck()
        {
            if(panel_attributes.Controls.Count == 0)
            {
                return true;
            }
            return false;
        }


        private bool VerifyPrompt()
        {
            // duplicated category name check
            if(categories.Any(category => category.CategoryName == rjTextBox_categoryName.Texts))
            {
                return false;
            }
            if(rjTextBox_categoryName.Texts == string.Empty)
            {
                return false;
            }
            return true;
        }
        private Category[] FindChildCategory(Category dadCategory)
        {
            return categories.Where(childCategory => childCategory.AncestorId == dadCategory.CategoryId).ToArray();
        }
        private Category FindDadCategoey(Category childCategory)
        {
            return categories.Single(dadCategory => dadCategory.CategoryId== childCategory.AncestorId);
        }


        #endregion













        #region Generate Control
        private Panel GenerateAttribute(string attribute)
        {
            Panel panel_attribute = new Panel();
            RJButton rjButton_deleteAttribute = new RJButton();
            RJButton rjButton5 = new RJButton();
            RJTextBox rjTextBox_attriibuteName = new RJTextBox();


            rjButton5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            rjButton5.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            rjButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton5.BorderRadius = 10;
            rjButton5.BorderSize = 0;
            rjButton5.Dock = System.Windows.Forms.DockStyle.Fill;
            rjButton5.Enabled = false;
            rjButton5.FlatAppearance.BorderSize = 0;
            rjButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton5.ForeColor = System.Drawing.Color.White;
            rjButton5.Location = new System.Drawing.Point(3, 0);
            rjButton5.Name = "rjButton5";
            rjButton5.Size = new System.Drawing.Size(255, 45);
            rjButton5.TabIndex = 0;
            rjButton5.TextColor = System.Drawing.Color.White;
            rjButton5.UseVisualStyleBackColor = false;

            rjButton_deleteAttribute.BackColor = System.Drawing.SystemColors.ControlLightLight;
            rjButton_deleteAttribute.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            rjButton_deleteAttribute.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton_deleteAttribute.BorderRadius = 10;
            rjButton_deleteAttribute.BorderSize = 0;
            rjButton_deleteAttribute.FlatAppearance.BorderSize = 0;
            rjButton_deleteAttribute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton_deleteAttribute.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rjButton_deleteAttribute.ForeColor = System.Drawing.Color.LightCoral;
            rjButton_deleteAttribute.Location = new System.Drawing.Point(215, 4);
            rjButton_deleteAttribute.Name = "rjButton_deleteAttribute";
            rjButton_deleteAttribute.Padding = new System.Windows.Forms.Padding(3, 0, 0, 2);
            rjButton_deleteAttribute.Size = new System.Drawing.Size(38, 38);
            rjButton_deleteAttribute.TabIndex = 2;
            rjButton_deleteAttribute.Text = "x";
            rjButton_deleteAttribute.TextColor = System.Drawing.Color.LightCoral;
            rjButton_deleteAttribute.UseVisualStyleBackColor = false;
            rjButton_deleteAttribute.Click += new System.EventHandler(RjButton_deleteAttribute_Click);
            //rjButton_deleteAttribute.TextChanged += 


            rjTextBox_attriibuteName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left))));
            rjTextBox_attriibuteName.BackColor = System.Drawing.SystemColors.Window;
            rjTextBox_attriibuteName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            rjTextBox_attriibuteName.BorderFocusColor = System.Drawing.Color.HotPink;
            rjTextBox_attriibuteName.BorderRadius = 10;
            rjTextBox_attriibuteName.BorderSize = 1;
            rjTextBox_attriibuteName.Font = new System.Drawing.Font("Tahoma", 10F);
            rjTextBox_attriibuteName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            rjTextBox_attriibuteName.Location = new System.Drawing.Point(15, 5);
            rjTextBox_attriibuteName.Margin = new System.Windows.Forms.Padding(4, 4, 10, 4);
            rjTextBox_attriibuteName.Multiline = false;
            rjTextBox_attriibuteName.Name = "rjTextBox_attriibuteName";
            rjTextBox_attriibuteName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            rjTextBox_attriibuteName.PasswordChar = false;
            rjTextBox_attriibuteName.PlaceholderColor = System.Drawing.Color.DarkGray;
            rjTextBox_attriibuteName.PlaceholderText = "";
            rjTextBox_attriibuteName.Size = new System.Drawing.Size(187, 36);
            rjTextBox_attriibuteName.TabIndex = 1;
            rjTextBox_attriibuteName.Texts = attribute;
            rjTextBox_attriibuteName.UnderlinedStyle = false;
            rjTextBox_attriibuteName._TextChanged += RjTextBox_attriibuteName__TextChanged;


            panel_attribute.Controls.Add(rjButton5);
            panel_attribute.Controls.Add(rjButton_deleteAttribute);
            panel_attribute.Controls.Add(rjTextBox_attriibuteName);

            panel_attribute.Controls.Add(rjButton5);
            panel_attribute.Dock = System.Windows.Forms.DockStyle.Top;
            panel_attribute.Location = new System.Drawing.Point(0, 10);
            panel_attribute.Name = "panel_attribute";
            panel_attribute.Padding = new System.Windows.Forms.Padding(3, 0, 3, 5);
            panel_attribute.Size = new System.Drawing.Size(261, 50);
            panel_attribute.TabIndex = 0;
            return panel_attribute;



        }

        

        private Panel GenerateCategory(Category category)
        {
            // rjButton_category
            // 
            RJButton rjButton_category = new RJButton();
            rjButton_category.BackColor = System.Drawing.Color.White;
            rjButton_category.BackgroundColor = System.Drawing.Color.White;
            rjButton_category.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton_category.BorderRadius = 15;
            rjButton_category.BorderSize = 0;
            rjButton_category.Dock = System.Windows.Forms.DockStyle.Fill;
            rjButton_category.FlatAppearance.BorderSize = 0;
            rjButton_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton_category.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rjButton_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            rjButton_category.Location = new System.Drawing.Point(5, 0);
            rjButton_category.Name = "rjButton_category";
            rjButton_category.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            rjButton_category.Size = new System.Drawing.Size(203, 47);
            rjButton_category.TabIndex = 0;
            rjButton_category.Text = category.CategoryName;
            rjButton_category.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            rjButton_category.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            rjButton_category.UseVisualStyleBackColor = false;
            rjButton_category.Click += RjButton_category_Click;

            Panel panel_category = new Panel();
            // panel_category
            // 
            panel_category.Controls.Add(rjButton_category);
            panel_category.Dock = System.Windows.Forms.DockStyle.Top;
            panel_category.Location = new System.Drawing.Point(0, 100);
            panel_category.Name = "panel_category";
            panel_category.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            panel_category.Size = new System.Drawing.Size(213, 52);
            panel_category.TabIndex = 0;
            // 

            return panel_category;

        }



        #endregion

        
    }
}
