using System;

namespace Proxy_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    interface IPersonal
    {
        void changePassport();
        void GetMyInfo();
        void ChangeAddress();

    }

    interface IAdminastry
    {
        void GetEveryoneinfo();
        void NotSomethingThatShouldBeAvilableForEveryone();
    }



    public class InteriorOffice : IAdminastry, IPersonal
    {
        public void ChangeAddress()
        {
            
        }

        public void changePassport()
        {
            
        }

        public void GetEveryoneinfo()
        {
            
        }

        public void GetMyInfo()
        {
           
        }

        public void NotSomethingThatShouldBeAvilableForEveryone()
        {
            
        }
    }

    public class ServiceMachine : IPersonal
    {

        private InteriorOffice InteriorOffice;

        public ServiceMachine(InteriorOffice INO)
        {
            InteriorOffice = INO;

        }

        public void ChangeAddress()
        {
            InteriorOffice.ChangeAddress();
        }

        public void changePassport()
        {
            InteriorOffice.changePassport();
        }

        public void GetMyInfo()
        {
            InteriorOffice.GetMyInfo();
        }
    }
}
