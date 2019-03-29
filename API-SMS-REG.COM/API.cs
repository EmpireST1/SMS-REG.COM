using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace API_SMS_REG.COM
{
    public class API
    {
        private static string GET(string target)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(target);
            request.Method = "GET";
            HttpWebResponse httpWebResponse = (HttpWebResponse)request.GetResponse();
            string result = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
            httpWebResponse.Close();
            return result;
        }
        public static string GetBalance(string apikey)
        {
            var result = JsonConvert.DeserializeObject<SMS_BALANCE>(GET($"http://api.sms-reg.com/getBalance.php?apikey={apikey}"));
            if (result.response == "1")
                return result.balance;
            else
                return null;
        }
        public static void SetUsed(string tzid, string apikey)
        {
            GET($"http://api.sms-reg.com/setOperationUsed.php?tzid={tzid}&apikey={apikey}");
        }
        public static async Task<Tuple<string, string>> GetNumber(string country, string appname, string apikey)
        {
            bool NeedGetNumber = false;
            do
            {
                string urlsms = $"http://api.sms-reg.com/getNum.php?country={country}&service={appname}&appid=UNW4UXNCXEUDX21&apikey={apikey}";
                var GetNumber = JsonConvert.DeserializeObject<GetNum>(GET(urlsms));
                if (GetNumber.response == "1")
                {
                    bool IsGotNumber = false;
                    var numb = JsonConvert.DeserializeObject<StateNumber>("");
                    string tzi = GetNumber.tzid;
                    int t = 0;
                    while (!IsGotNumber)
                    {
                        await Task.Delay(15000);
                        urlsms = $"http://api.sms-reg.com/getState.php?tzid={GetNumber.tzid}&apikey={apikey}";
                        numb = JsonConvert.DeserializeObject<StateNumber>(GET(urlsms));
                        if (numb.response == "WARNING_NO_NUMS")
                        {
                            IsGotNumber = true;
                            NeedGetNumber = true;
                            await Task.Delay(15000);
                        }
                        else if (numb.response != "TZ_NUM_PREPARE")
                        {
                            await Task.Delay(15000);
                            IsGotNumber = false;
                        }
                        else if (numb.response == "TZ_NUM_PREPARE")
                        {
                            IsGotNumber = true;
                            string number = numb.number;
                            return Tuple.Create(tzi, number);
                        }
                        t++;
                        if (t > 20)
                        {
                            IsGotNumber = true;
                            NeedGetNumber = true;
                            await Task.Delay(15000);
                        }
                    }

                }
                else if(GetNumber.response=="ERROR")
                {
                    return null;
                }
                else
                {
                    NeedGetNumber = true;
                }
            } while (NeedGetNumber);
            return null;
        }
        public static async Task<string> GetCode(string tzid, string apikey)
        {
            string urlsms = $"http://api.sms-reg.com/setReady.php?tzid={tzid}&apikey={apikey}";
            GET(urlsms);
            bool YetNotGet = true;
            int x = 0;
            while (YetNotGet)
            {
                x++;
                if (x > 6)
                {
                    YetNotGet = false;
                    urlsms = $"http://api.sms-reg.com/setOperationUsed.php?tzid={tzid}&apikey={apikey}";
                    GET(urlsms);
                    return null;
                }
                else
                {
                    await Task.Delay(60000);
                    urlsms = $"http://api.sms-reg.com/getState.php?tzid={tzid}&apikey={apikey}";
                    var SMS = JsonConvert.DeserializeObject<MSG>(GET(urlsms));
                    if (SMS.response != "TZ_NUM_WAIT")
                    {
                        YetNotGet = false;
                        return SMS.msg;
                    }
                }
            }
            return null;
        }
    }
}
