using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexPaymentForm
{
    public class YdPayForm
    {
        /// <summary>
        /// номер кошелька в Яндекс.Деньгах, на который нужно зачислять деньги отправителей.
        /// </summary>
        public string receiver { get; set; }
        /// <summary>
        /// (до 50 символов) — название перевода в истории отправителя. 
        /// Удобнее всего формировать его из названий магазина и товара.Например, «Мой магазин: валенки белые».
        /// </summary>
        public string formcomment { get; set; }
        /// <summary>
        /// название перевода на странице подтверждения. Рекомендуем делать его таким же, как formcomment.
        /// Сигнатура: short-dest
        /// </summary>
        public string short_dest { get; set; }
        /// <summary>
        /// Сигнатура: quickpay-form
        /// </summary>
        public QuickpayForm quickpay_form { get; set; }
        /// <summary>
        /// (до 150 символов) — назначение платежа.
        /// </summary>
        public string targets { get; set; }
        public PaymentType paymentType { get; set; }
        /// <summary>
        /// сумма перевода.
        /// </summary>
        public double sum { get; set; }
        /// <summary>
        /// (до 64 символов) — метка, которую сайт или приложение присваивает конкретному переводу. Например, в качестве метки можно указывать код или идентификатор заказа.
        /// </summary>
        public string label { get; set; }
        /// <summary>
        /// URL-адрес для редиректа после совершения перевода.
        /// </summary>
        public string successURL { get; set; }
    }
}
