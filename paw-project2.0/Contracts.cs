using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paw_project2._0
{
    [Serializable]
    public class Contract
    {
        public long Id { get; set; }
        private Provider provider;
        public DateTime signDate;
        public long validity;
        public long worth;

        public Contract()
        {
            provider = null;
            signDate = new DateTime(2021, 1, 1);
            validity = 1;
            worth = 1;
        }

        public Contract(Provider provider, DateTime signDate, long validity, long worth)
        {
            this.provider = provider;
            this.signDate = signDate;
            this.validity = validity;
            this.worth = worth;
        }

        public Contract(long id, Provider provider, DateTime signDate, long validity, long worth)
            : this(provider, signDate, validity, worth)
        {
            Id = id;
        }

        public Provider Provider
        {
            get { return provider; }
            set
            {
                if (value != null)
                {
                    provider = value;
                }
            }
        }

        public DateTime SignDate
        {
            get { return signDate; }
            set
            {
                if (value > DateTime.Today.AddDays(1))
                {
                    throw new InvalidSignDateException(value);
                }
                signDate = value;
            }
        }

        public long Validity
        {
            get { return validity; }
            set
            {
                if (value > 0)
                {
                    validity = value;
                }
            }
        }

        public long Worth
        {
            get { return worth; }
            set
            {
                if (value > 0)
                {
                    worth = value;
                }
            }
        }

        public override string ToString()
        {
            string mesaj = this.provider + "; Date of signing the contract: " + this.signDate + "; Validity: " + this.validity + "; The value of the contract: " + this.worth;
            return mesaj;
        }
    }
}
