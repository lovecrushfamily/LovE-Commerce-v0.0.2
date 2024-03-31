var MAINPLERDYURL="https://a.plerdy.com/";var mainScriptPlerdy=document.querySelector('[src*="public/js/click/main.js"]');var mainScriptPlerdy_host,mainScriptPlerdy_host_tracker;if(mainScriptPlerdy){try{let mainScriptPlerdy_url=new URL(mainScriptPlerdy.src);if(mainScriptPlerdy_url.host){mainScriptPlerdy_host=mainScriptPlerdy_url.host;}else{mainScriptPlerdy_host="a.plerdy.com";}}catch(err){mainScriptPlerdy_host="a.plerdy.com";}}else{mainScriptPlerdy_host="a.plerdy.com";}
if(mainScriptPlerdy_host=='a.plerdy.com'){mainScriptPlerdy_host_tracker='https://c.plerdy.com';mainScriptPlerdy_host="https://"+mainScriptPlerdy_host;if(typeof _suid!=='undefined'&&(_suid==37113||_suid*1>=50000)){mainScriptPlerdy_host_tracker='https://f.plerdy.com';}}else if(mainScriptPlerdy_host=='test.plerdy.com'){mainScriptPlerdy_host_tracker='https://test.plerdy.com';mainScriptPlerdy_host="https://"+mainScriptPlerdy_host;}else if(mainScriptPlerdy_host=='d.plerdy.com'){mainScriptPlerdy_host_tracker='https://d.plerdy.com';mainScriptPlerdy_host="https://"+mainScriptPlerdy_host;if(typeof _suid!=='undefined'&&(_suid*1>=41074)){}}else if(mainScriptPlerdy_host=='plerdy.loc'){mainScriptPlerdy_host_tracker='http://plerdy.loc';mainScriptPlerdy_host="http://"+mainScriptPlerdy_host;}else{mainScriptPlerdy_host_tracker='https://tracker.plerdy.com';mainScriptPlerdy_host="https://"+mainScriptPlerdy_host;}
var plerdy_config={plerdy_url0:mainScriptPlerdy_host+"/",plerdy_url_live:mainScriptPlerdy_host+"/",plerdy_url_save:mainScriptPlerdy_host_tracker+"/click/",plerdy_url_save_test:mainScriptPlerdy_host_tracker+"/click_test/"};if(!Array.prototype.forEach){Array.prototype.forEach=function(fn,scope){for(var i=0,len=this.length;i<len;++i){fn.call(scope,this[i],i,this);}}}
if(window.NodeList&&!NodeList.prototype.forEach){NodeList.prototype.forEach=Array.prototype.forEach;};function getPlerdy_PageUrl(eneble_hash_val){if(eneble_hash_val===undefined){eneble_hash_val=false;}
if(location.host.indexOf('console.theviewpoint.com')*1>-1&&window.location.href.indexOf('console.theviewpoint.com/campaigns/edit')*1>-1){var baseUrl='https://console.theviewpoint.com/campaigns/edit/3498665';}else if(location.host.indexOf('console.theviewpoint.com')*1>-1&&window.location.href.indexOf('console.theviewpoint.com/inventory/channel')*1>-1){var baseUrl='https://console.theviewpoint.com/inventory/channel/1295';}else if(location.host.indexOf('console.theviewpoint.com')*1>-1&&window.location.href.indexOf('console.theviewpoint.com/inventory/placement')*1>-1){var baseUrl='https://console.theviewpoint.com/inventory/placement/129';}else{var baseUrl=window.location.protocol+'//'+window.location.host+window.location.pathname.replace(/\/+$/,'').replace('[object SVGAnimatedString]','');}
if((location.host.indexOf('redtag.ca')*1>-1||location.host.indexOf('itravel2000.com')*1>-1)&&(window.location.href.indexOf('secure.redtag.ca/res/vacations/search?')*1>-1||window.location.href.indexOf('secure.redtag.ca/res/vacations/book/payment?')*1>-1||window.location.href.indexOf('secure.redtag.ca/res/vacations/search/hotel?')*1>-1||window.location.href.indexOf('res.redtag.ca/hotel/search?')*1>-1||window.location.href.indexOf('secure.redtag.ca/resvfltt/flights/search?')*1>-1||window.location.href.indexOf('res.itravel2000.com/res/vacations/search?')*1>-1||window.location.href.indexOf('res.itravel2000.com/res/vacations/search/hotel?')*1>-1||window.location.href.indexOf('res.itravel2000.com/res/vacations/book/payment?')*1>-1)){var search='';}else{var search=window.location.search.substring(1);}
if(location.host.indexOf("sellcodes.com")>-1){if(location.href.indexOf("sellcodes.com/embed/checkout-frame/XdHlrQnc")>-1){var search='';}}
search=search.replace('==','');if(search){try{var params=JSON.parse('{"'+decodeURI(search).replace(/"/g,'\\"').replace(/&/g,'","').replace(/=/g,'":"')+'"}');}catch(err){params={};}
if(location.host.indexOf('intimo.com')*1>-1){if(params.campaign!=='undefined'){delete params.campaign;}}
if(location.host.indexOf('tampaesthetics.com')*1>-1){if(params._atid!=='undefined'){delete params._atid;}}
if(location.host.indexOf('psgsecrets.com')*1>-1){if(params.ag!=='undefined'){delete params.ag;}
if(params.imb!=='undefined'){delete params.imb;}}
if(location.host.indexOf("payquad.com")>-1||location.host.indexOf("btahelps.com")>-1){if(params.campaign!=='undefined'){delete params.campaign;}}
if(_suid==40165||location.host.indexOf('lp.cconcreto.com')>-1){if(params.ctvo!=='undefined'){delete params.ctvo;}
if(params.hsa_acc!=='undefined'){delete params.hsa_acc;}
if(params.hsa_ad!=='undefined'){delete params.hsa_ad;}
if(params.hsa_cam!=='undefined'){delete params.hsa_cam;}
if(params.hsa_grp!=='undefined'){delete params.hsa_grp;}
if(params.hsa_net!=='undefined'){delete params.hsa_net;}
if(params.hsa_src!=='undefined'){delete params.hsa_src;}
if(params.hsa_ver!=='undefined'){delete params.hsa_ver;}}
if(location.host.indexOf('pobeda')*1===-1){if(params.utm_source!=='undefined'){delete params.utm_source;}
if(params.utm_medium!=='undefined'){delete params.utm_medium;}
if(params.utm_content!=='undefined'){delete params.utm_content;}
if(params.utm_campaign!=='undefined'){delete params.utm_campaign;}
if(params.utm_term!=='undefined'){delete params.utm_term;}
if(params.utm_adgroup!=='undefined'){delete params.utm_adgroup;}
if(params.utm_creative!=='undefined'){delete params.utm_creative;}
if(params.utm_placement!=='undefined'){delete params.utm_placement;}
if(params.mcp_token!=='undefined'){delete params.mcp_token;}}
if(location.host.indexOf('natalibolgar')*1>-1){if(params.top!=='undefined'){delete params.top;}}
if(location.host.indexOf('getfound.live')*1>-1){if(params._thumbnail_id!=='undefined'){delete params._thumbnail_id;}
if(params.preview!=='undefined'){delete params.preview;}
if(params.preview_id!=='undefined'){delete params.preview_id;}
if(params.preview_nonce!=='undefined'){delete params.preview_nonce;}
if(params._vcnonce!=='undefined'){delete params._vcnonce;}
if(params.vc_editable!=='undefined'){delete params.vc_editable;}
if(params.vc_post_id!=='undefined'){delete params.vc_post_id;}
if(params.dsi!=='undefined'){delete params.dsi;}
if(params.ei!=='undefined'){delete params.ei;}
if(params.sp_pvosi!=='undefined'){delete params.sp_pvosi;}
if(params.sp_tag!=='undefined'){delete params.sp_tag;}
if(params.customize_changeset_uuid!=='undefined'){delete params.customize_changeset_uuid;}
if(params.customize_messenger_channel!=='undefined'){delete params.customize_messenger_channel;}
if(params.customize_theme!=='undefined'){delete params.customize_theme;}
if(params.gtm_debug!=='undefined'){delete params.gtm_debug;}
if(params.post_type!=='undefined'){delete params.post_type;}
if(params.p!=='undefined'){delete params.p;}
if(params.s!=='undefined'){delete params.s;}
if(params.cmid!=='undefined'){delete params.cmid;}
if(params.page_id!=='undefined'){delete params.page_id;}
if(params.route!=='undefined'){delete params.route;}
if(params.vgo_ee!=='undefined'){delete params.route;}
if(params.wbraid!=='undefined'){delete params.wbraid;}}
if(location.host.indexOf('daytradereview')*1>-1){if(params.k!=='undefined'){delete params.k;}
if(params.d!=='undefined'){delete params.d;}
if(params.ag!=='undefined'){delete params.ag;}}
if(location.host.indexOf('thedolcediet')*1>-1){if(location.href&&location.href.indexOf('create-account')*1>-1){if(params.email!=='undefined'){delete params.email;}
if(params.token!=='undefined'){delete params.token;}
if(params.program!=='undefined'){delete params.program;}}
if(location.href&&location.href.indexOf('sign-up')*1>-1){if(params.email!=='undefined'){delete params.email;}
if(params.token!=='undefined'){delete params.token;}
if(params.program!=='undefined'){delete params.program;}}}
if(location.host.indexOf('vanguardly')*1>-1){if(params._hsenc!=='undefined'){delete params._hsenc;}
if(params._hsm!=='undefined'){delete params._hsm;}
if(params.__hssc!=='undefined'){delete params.__hssc;}
if(params.__hstc!=='undefined'){delete params.__hstc;}
if(params.hsCtaTracking!=='undefined'){delete params.hsCtaTracking;}
if(params.submissionGuid!=='undefined'){delete params.submissionGuid;}
if(params.hsa_cam!=='undefined'){delete params.hsa_cam;}
if(params.hsa_grp!=='undefined'){delete params.hsa_grp;}
if(params.hsa_mt!=='undefined'){delete params.hsa_mt;}
if(params.hsa_src!=='undefined'){delete params.hsa_src;}
if(params.hsa_ad!=='undefined'){delete params.hsa_ad;}
if(params.hsa_acc!=='undefined'){delete params.hsa_acc;}
if(params.hsa_net!=='undefined'){delete params.hsa_net;}
if(params.hsa_kw!=='undefined'){delete params.hsa_kw;}
if(params.hsa_tgt!=='undefined'){delete params.hsa_tgt;}
if(params.hsa_ver!=='undefined'){delete params.hsa_ver;}
if(params.hsa_la!=='undefined'){delete params.hsa_la;}
if(params.hsa_ol!=='undefined'){delete params.hsa_ol;}}
if(location.host.indexOf('tvbetframe')*1>-1){if(params.tokenAuth!=='undefined'){delete params.tokenAuth;}}
if(params.utm_id!=='undefined'){delete params.utm_id;}
if(params._ga!=='undefined'){delete params._ga;}
if(params._gac!=='undefined'){delete params._ga;}
if(params.roistat!=='undefined'){delete params.roistat;}
if(params.roistat_referrer!=='undefined'){delete params.roistat_referrer;}
if(params.roistat_pos!=='undefined'){delete params.roistat_pos;}
if(params.gclid!=='undefined'){delete params.gclid;}
if(params.rs!=='undefined'){delete params.rs;}
if(params.spush!=='undefined'){delete params.spush;}
if(params.goal!=='undefined'){delete params.goal;}
if(params.cref_id!=='undefined'){delete params.cref_id;}
if(params.mref_id!=='undefined'){delete params.mref_id;}
if(params.sourse_id!=='undefined'){delete params.sourse_id;}
if(params.guid!=='undefined'){delete params.guid;}
if(params.fbclid!=='undefined'){delete params.fbclid;}
if(params.tblci!=='undefined'){delete params.tblci;}
if(params.fbc_id!=='undefined'){delete params.fbc_id;}
if(location.host.indexOf('vanguardly')*1>-1){if(params._hsenc!=='undefined'){delete params._hsenc;}
if(params._hsm!=='undefined'){delete params._hsm;}
if(params.__hssc!=='undefined'){delete params.__hssc;}
if(params.__hstc!=='undefined'){delete params.__hstc;}
if(params.hsCtaTracking!=='undefined'){delete params.hsCtaTracking;}
if(params.submissionGuid!=='undefined'){delete params.submissionGuid;}
if(params.hsa_cam!=='undefined'){delete params.hsa_cam;}
if(params.hsa_grp!=='undefined'){delete params.hsa_grp;}
if(params.hsa_mt!=='undefined'){delete params.hsa_mt;}
if(params.hsa_src!=='undefined'){delete params.hsa_src;}
if(params.hsa_ad!=='undefined'){delete params.hsa_ad;}
if(params.hsa_acc!=='undefined'){delete params.hsa_acc;}
if(params.hsa_net!=='undefined'){delete params.hsa_net;}
if(params.hsa_kw!=='undefined'){delete params.hsa_kw;}
if(params.hsa_tgt!=='undefined'){delete params.hsa_tgt;}
if(params.hsa_ver!=='undefined'){delete params.hsa_ver;}
if(params.hsa_la!=='undefined'){delete params.hsa_la;}
if(params.hsa_ol!=='undefined'){delete params.hsa_ol;}}
if(location.host==='demo.stripo.email'){if(params.project!=='undefined'){delete params.project;}
if(params.template!=='undefined'){delete params.template;}}
if(location.host==='www.moyo.ua'){if(params.adgroup!=='undefined'){delete params.adgroup;}
if(params.feeditem!=='undefined'){delete params.feeditem;}}
if(location.host.indexOf('ketodietnd.com')>-1){if(params.TID!=='undefined'){delete params.TID;}
if(params.host!=='undefined'){delete params.host;}
if(params.c!=='undefined'){delete params.c;}}
var str=[];for(var p in params){if(params.hasOwnProperty(p)){str.push(encodeURIComponent(p)+"="+encodeURIComponent(params[p]));}}
var query_str=str.join("&");}else{var query_str='';}
if(window.location.hash&&eneble_hash_val){var hash=window.location.hash;}else{var hash='';}
if(_suid*1===1881){query_str='';}
var lastChar=initPlerdyUrlOriginal.substr(-1);if(lastChar==='/'){baseUrl=baseUrl+'/';}
if(location.host.indexOf('my.claspo')*1>-1){if(query_str==''){return baseUrl+"/"+window.location.hash;}else{return baseUrl+'?'+query_str+"/"+window.location.hash;};}
if(query_str==''){return baseUrl+hash;}else{return baseUrl+'?'+query_str+hash;}}
function mobilecheck(){var check=false;(function(a){if(/(android|bb\d+|meego).+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|mobile.+firefox|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|series(4|6)0|symbian|treo|up\.(browser|link)|vodafone|wap|windows ce|xda|xiino/i.test(a)||/1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-/i.test(a.substr(0,4)))
check=true;})(navigator.userAgent||navigator.vendor||window.opera);return check;}
function mobileAndTabletcheck(){var check=false;(function(a){if(/(android|bb\d+|meego).+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|mobile.+firefox|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|series(4|6)0|symbian|treo|up\.(browser|link)|vodafone|wap|windows ce|xda|xiino|android|ipad|playbook|silk/i.test(a)||/1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-/i.test(a.substr(0,4)))
check=true;})(navigator.userAgent||navigator.vendor||window.opera);return check;}
function plerdyGetOS(){try{var userAgent=window.navigator.userAgent,platform=window.navigator.platform,macosPlatforms=['Macintosh','MacIntel','MacPPC','Mac68K'],windowsPlatforms=['Win32','Win64','Windows','WinCE'],iosPlatforms=['iPhone','iPad','iPod'],os='';if(macosPlatforms.indexOf(platform)!==-1){os='Mac OS';}else if(iosPlatforms.indexOf(platform)!==-1){os='iOS';}else if(windowsPlatforms.indexOf(platform)!==-1){os='Windows';}else if(/Android/.test(userAgent)){os='Android';}else if(!os&&/Linux/.test(platform)){os='Linux';}}catch(err){return 'Unknown OS';}
return os?os:'Unknown OS';}
function plerdyGetBrouser(){var br='Unknown Browser';try{var userAgentString=navigator.userAgent;var chromeAgent=userAgentString.indexOf("Chrome")>-1;var IExplorerAgent=userAgentString.indexOf("MSIE")>-1||userAgentString.indexOf("rv:")>-1;var firefoxAgent=userAgentString.indexOf("Firefox")>-1;var safariAgent=userAgentString.indexOf("Safari")>-1;if((chromeAgent)&&(safariAgent))
safariAgent=false;var operaAgent=userAgentString.indexOf("OP")>-1;if((chromeAgent)&&(operaAgent))
chromeAgent=false;if(chromeAgent){br="Google Chrome";}else if(firefoxAgent){br="Mozilla Firefox";}else if(IExplorerAgent){br="Internet Exploder";}else if(safariAgent){br="Safari";}else if(operaAgent){br="Opera";}else if(navigator.userAgent.indexOf("ya")!=-1){br="YaBrowser";}else{br="Other Browser";}}catch(err){br="Other Browser";}
return br;}