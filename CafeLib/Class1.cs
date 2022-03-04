using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    public abstract class HotDrink
    {
        public bool instant;
        public bool milk;
        private byte sugar;
        public Customer customer;

        public virtual void AddSugar(byte amount)
        {

        }
        public abstract void Steam();
        public HotDrink()
        {

        }

        public HotDrink(string brand)
        {

        }


    }
    public interface IMood
    {
        string Mood
        {
            get;
        }

    }

    public interface ITakeOrder
    {
        void TakeOrder();
    }
    public class Customer
    {
        public string name;
        public string creditCardNumber;

        public string Mood
        {
            get { return Mood; }

        }

    }

    public class Waiter : IMood
    {
        public string name;
        public string Mood
        {
            get
            {
                return Mood;
            }
        }
        public void ServeCustomer(HotDrink cup)
        {

        }
    }
    public class CupOfCoffee : HotDrink, ITakeOrder
    {
        public string beanType;

        public override void Steam()
        {

        }
        public void TakeOrder()
        {

        }

        public CupOfCoffee(string brand) : base(brand)
        {

        }
    }

    public class CupOfTea : HotDrink, ITakeOrder
    {
        public string leafType;
        public override void Steam()
        {

        }

        public void TakeOrder()
        {

        }

        public CupOfTea(bool customerIsWealthy)
        {

        }

    }

    public class CupOfCocoa : HotDrink, ITakeOrder
    {

        public static int numCups;
        public bool marshallows;
        private string source;
        public override void Steam()
        {

        }
        public void TakeOrder()
        {

        }
        public string Source
        {
            set
            {
                source = value;
            }
        }
        public override void AddSugar(byte amount)
        {

        }

        public CupOfCocoa() : this(false)
        {

        }
        public CupOfCocoa(bool marshmallows) : base("Expensive Organic Brand")
        {

        }
    }
}
