using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexPaymentForm
{
    /// <summary>
    ///  определяет тип транзакции. Возможные значения:
    /// </summary>
    public enum QuickpayForm
    {
        /// <summary>
        /// для универсальной формы
        /// </summary>
        shop,
        /// <summary>
        /// для «благотворительной» формы
        /// </summary>
        donate,
        /// <summary>
        /// для кнопки
        /// </summary>
        small
    }
}
