# SMS-REG.COM
<h1>API for SMS-REG.COM + dll</h1>
<h1><code>using API_SMS_REG.COM;</code></h1>
<h1>For Get Number</h1>
<code>
var TzidAndNumber = await Task.Run(() => API.GetNumber(country, app, apikey));</br>
                if (TzidAndNumber != null)</br>
                {</br>
                   string tzid = TzidAndNumber.Item1);</br>
                   string Number = TzidAndNumber.Item2);</br>
                }</br>
                else</br>
                {</br>
                    MessageBox.Show("Wrong ApiKey!");</br>
                }</code>
<h1>For  Get Code</h1>
<code>
string code = await Task.Run(() => API.GetCode(tzid, apikey));</br>
                if (code != null)</br>
                    string code = code;</code>
<h1>For Set Used</h1>
<code>
Task.Run(() => API.SetUsed(tzid, apikey));</code>

<h1>For Get Balance (You can convert it to double)</h1>
<code>
string balance = await Task.Run(() => API.GetBalance(ApiKey.Text));</code>

<h1>Countrys:</h1>
<code>
            Dictionary<string, string> countrys = new Dictionary<string, string>();</br>
            countrys.Add("All", "all");</br>
            countrys.Add("Russia", "ru");</br>
            countrys.Add("Ukraine", "ua");</br>
            countrys.Add("Kazakhstan", "kz");</br>
            countrys.Add("China", "cn");</code>
  <h1>Apps:</h1>
 <code>
            Dictionary<string, string> apps = new Dictionary<string, string>();</code><code>
            apps.Add("Other", "other");</br>
            apps.Add("Aol.com", "aol");</br>
            apps.Add("Gmail.com", "gmail");</br>
            apps.Add("Facebook.com", "facebook");</br>
            apps.Add("Mail.ru", "mailru");</br>
            apps.Add("Vk.com", "vk");</br>
            apps.Add("Ok.ru", "classmates");</br>
            apps.Add("Twitter", "twitter");</br>
            apps.Add("Mamba", "mamba");</br>
            apps.Add("Uber", "uber");</br>
            apps.Add("Telegram", "telegram");</br>
            apps.Add("Badoo", "badoo");</br>
            apps.Add("Drugvokrug", "drugvokrug");</br>
            apps.Add("Avito", "avito");</br>
            apps.Add("OLX", "olx");</br>
            apps.Add("Steam", "steam");</br>
            apps.Add("Fotostrana.ru", "fotostrana");</br>
            apps.Add("Microsoft", "microsoft");</br>
            apps.Add("Viber", "viber");</br>
            apps.Add("WhatsApp", "whatsapp");</br>
            apps.Add("WeChat", "wechat");</br>
            apps.Add("SEOsprint", "seosprint");</br>
            apps.Add("Instagram", "instagram");</br>
            apps.Add("Yahoo", "yahoo");</br>
            apps.Add("Line Messanger", "lineme");</br>
            apps.Add("KakaoTalk", "kakaotalk");</br>
            apps.Add("MeetMe", "meetme");</br>
            apps.Add("Tinder", "tinder");</br>
            apps.Add("Nimses", "nimses");</br>
            apps.Add("Youla.ru", "youla");</br>
            apps.Add("5ka.ru", "5ka");</code>
