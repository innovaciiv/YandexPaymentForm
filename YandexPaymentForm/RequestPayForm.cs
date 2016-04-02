using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexPaymentForm
{
    public class RequestPayForm
    {
        /// <summary>
        /// Для переводов из кошелька — p2p-incoming. Для переводов с произвольной карты — card-incoming.
        /// </summary>
        public string notification_type { get; set; }
        /// <summary>
        /// Идентификатор операции в истории счета получателя.
        /// </summary>
        public string operation_id { get; set; }
        /// <summary>
        /// Сумма, которая зачислена на счет получателя.
        /// </summary>
        public string amount { get; set; }
        /// <summary>
        /// Сумма, которая списана со счета отправителя.
        /// Сигнатура: withdraw-amount
        /// </summary>
        public string withdraw_amount { get; set; }
        /// <summary>
        /// Код валюты — всегда 643 (рубль РФ согласно ISO 4217).
        /// </summary>
        public string currency { get; set; }
        /// <summary>
        /// Дата и время совершения перевода.
        /// </summary>
        public string datetime { get; set; }
        /// <summary>
        /// Для переводов из кошелька — номер счета отправителя. 
        /// Для переводов с произвольной карты — параметр содержит пустую строку.
        /// </summary>
        public string sender { get; set; }
        /// <summary>
        /// Для переводов из кошелька — перевод защищен кодом протекции. 
        /// Для переводов с произвольной карты — всегда false.
        /// </summary>
        public string codepro { get; set; }
        /// <summary>
        /// Метка платежа. Если ее нет, параметр содержит пустую строку.
        /// </summary>
        public string label { get; set; }
        /// <summary>
        /// SHA-1 hash параметров уведомления.
        /// </summary>
        public string sha1_hash { get; set; }

        public string lastname { get; set; }

        public string firstname { get; set; }

        public string fathersname { get; set; }

        public string email { get; set; }

        public string phone { get; set; }

        public string city { get; set; }


        public string street { get; set; }

        public string building { get; set; }

        public string suite { get; set; }

        public string flat { get; set; }
        public string zip { get; set; }

        public RequestPayForm() { }
        public RequestPayForm(NameValueCollection nvc)
        {
            operation_id = nvc.Get("operation_id");
            amount = nvc.Get("amount");
            notification_type = nvc.Get("notification_type");
            currency = nvc.Get("currency");
            datetime = nvc.Get("datetime");
            sender = nvc.Get("sender");
            codepro = nvc.Get("codepro");
            label = nvc.Get("label");
            sha1_hash = nvc.Get("sha1_hash");
        }
    }
}
