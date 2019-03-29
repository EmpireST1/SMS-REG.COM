# SMS-REG.COM
<h1>API for SMS-REG.COM + dll</h1>
<h1><code>using API_SMS_REG.COM;</code></h1>
<h1>For Get Number</h1>
<code>
var TzidAndNumber = await Task.Run(() => API.GetNumber(country, app, apikey));</code><code>
                if (TzidAndNumber != null)</code><code>
                {</code><code>
                   string tzid = TzidAndNumber.Item1);</code><code>
                   string Number = TzidAndNumber.Item2);</code><code>
                }</code><code>
                else</code><code>
                {</code><code>
                    MessageBox.Show("Wrong ApiKey!");</code><code>
                }</code>
<h1>For  Get Code</h1>
<code>
string code = await Task.Run(() => API.GetCode(tzid, apikey));</code><code>
                if (code != null)</code><code>
                    string code = code;</code>
<h1>For Set Used</h1>
<code>
Task.Run(() => API.SetUsed(tzid, apikey));</code>

<h1>For Get Balance (You can convert it to double)</h1>
<code>
string balance = await Task.Run(() => API.GetBalance(ApiKey.Text));</code>

<h1>Countrys:</h1>
<code>
            Dictionary<string, string> countrys = new Dictionary<string, string>();</code><code>
            countrys.Add("All", "all");</code><code>
            countrys.Add("Russia", "ru");</code><code>
            countrys.Add("Ukraine", "ua");</code><code>
            countrys.Add("Kazakhstan", "kz");</code><code>
            countrys.Add("China", "cn");</code>
  <h1>Apps:</h1>
 <code>
            Dictionary<string, string> apps = new Dictionary<string, string>();</code><code>
            apps.Add("Other", "other");</code><code>
            apps.Add("Aol.com", "aol");</code><code>
            apps.Add("Gmail.com", "gmail");</code><code>
            apps.Add("Facebook.com", "facebook");</code><code>
            apps.Add("Mail.ru", "mailru");</code><code>
            apps.Add("Vk.com", "vk");</code><code>
            apps.Add("Ok.ru", "classmates");</code><code>
            apps.Add("Twitter", "twitter");</code><code>
            apps.Add("Mamba", "mamba");</code><code>
            apps.Add("Uber", "uber");</code><code>
            apps.Add("Telegram", "telegram");</code><code>
            apps.Add("Badoo", "badoo");</code><code>
            apps.Add("Drugvokrug", "drugvokrug");</code><code>
            apps.Add("Avito", "avito");</code><code>
            apps.Add("OLX", "olx");</code><code>
            apps.Add("Steam", "steam");</code><code>
            apps.Add("Fotostrana.ru", "fotostrana");</code><code>
            apps.Add("Microsoft", "microsoft");</code><code>
            apps.Add("Viber", "viber");</code><code>
            apps.Add("WhatsApp", "whatsapp");</code><code>
            apps.Add("WeChat", "wechat");</code><code>
            apps.Add("SEOsprint", "seosprint");</code><code>
            apps.Add("Instagram", "instagram");</code><code>
            apps.Add("Yahoo", "yahoo");</code><code>
            apps.Add("Line Messanger", "lineme");</code><code>
            apps.Add("KakaoTalk", "kakaotalk");</code><code>
            apps.Add("MeetMe", "meetme");</code><code>
            apps.Add("Tinder", "tinder");</code><code>
            apps.Add("Nimses", "nimses");</code><code>
            apps.Add("Youla.ru", "youla");</code><code>
            apps.Add("5ka.ru", "5ka");</code>
