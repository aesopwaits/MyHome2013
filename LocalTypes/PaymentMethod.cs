﻿namespace LocalTypes
{
    public class PaymentMethod : BaseCategory
    {
        #region C'Tor

        public PaymentMethod(int id, string name)
        {
            base.Id = id;
            base.Name = name;
        }

        #endregion

        #region Other Methods

        #region Override Methods

        public override string ToString()
        {
            return this.Name;
        }

        public bool Equals(PaymentMethod paymentMethod)
        {
            return ((this.Id == paymentMethod.Id) &&
                    (this.Name == paymentMethod.Name));
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

        #endregion
    }
}
