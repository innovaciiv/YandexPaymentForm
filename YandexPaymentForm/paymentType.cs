using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexPaymentForm
{
    public enum PaymentType
    {
        /// <summary>
        /// оплата из кошелька в Яндекс.Деньгах;
        /// </summary>
        PC,
        /// <summary>
        ///  с банковской карты;
        /// </summary>
        AC,
        /// <summary>
        /// с баланса мобильного.
        /// </summary>
        MC
    }
}
