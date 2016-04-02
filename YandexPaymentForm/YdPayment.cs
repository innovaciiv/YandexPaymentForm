using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace YandexPaymentForm
{
    public class YdPayment
    {
        public string PostAddress { get { return "https://money.yandex.ru/quickpay/confirm.xml"; } }

        public string notification_secret { get; set; }

        public YdPayment() { }

        public YdPayment(string _notification_secret) { notification_secret = _notification_secret; }

        public Dictionary<string, object> GetPostData(YdPayForm YdPayForm)
        {
            Dictionary<string, object> postData = new Dictionary<string, object>();
            postData.Add("receiver", YdPayForm.receiver);
            postData.Add("formcomment", YdPayForm.formcomment);
            postData.Add("short-dest", YdPayForm.short_dest);
            postData.Add("quickpay-form", YdPayForm.quickpay_form.ToString());
            postData.Add("targets", YdPayForm.targets);
            postData.Add("paymentType", YdPayForm.paymentType.ToString());
            postData.Add("sum", YdPayForm.sum.ToString("0.00"));
            postData.Add("label", YdPayForm.label);
            postData.Add("successURL", YdPayForm.successURL);
            return postData;
        }

        public int GetLabel(NameValueCollection form)
        {
            return int.Parse(new RequestPayForm(form).label);
        }

        public Answer GetAnswer(NameValueCollection form)
        {
            Answer answer = new Answer();
            var reqForm = new RequestPayForm(form);
            string paramString = reqForm.notification_type +
                "&" + reqForm.operation_id +
                "&" + reqForm.amount +
                "&" + reqForm.currency +
                "&" + reqForm.datetime +
                "&" + reqForm.sender +
                "&" + reqForm.codepro +
                "&" + notification_secret +
                "&" + reqForm.label;
            if (reqForm.sha1_hash == Hash(paramString))
            {
                answer.Key = true;
                answer.Value = "OK";
            }
            else
            {
                answer.Key = false;
                answer.Value = "HASH не верен";
            }
            return answer;

        }

        static string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }

    }
}
