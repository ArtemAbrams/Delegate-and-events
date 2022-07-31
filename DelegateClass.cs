namespace ConsoleApp
{
    delegate void PrintMessage(string message, int sum);

    class DelegateClass
    {
        int sum;
        PrintMessage? prtmsg = null;

        public DelegateClass(int sum)
        {
            this.sum = sum;
        }

        public void AddMethod(PrintMessage prtmsg)
        {
            this.prtmsg += prtmsg;
        }

        public void DeleteMethod(PrintMessage prtmsg)
        {
            if (this.prtmsg == null)
                Console.WriteLine("Cringe");
            else
                this.prtmsg -= prtmsg;
        }
        public void Add(int sum)
        {
            if (prtmsg != null)
            {
                this.sum += sum;
                prtmsg.Invoke("You add money, your balance", this.sum);
            }
            else
                Console.WriteLine("No method");
        }

        public void Taken(int sum)
        {
            if (prtmsg == null)
            {
                Console.WriteLine("No method");
            }
            else
            {
                if (this.sum < sum)
                {
                    prtmsg.Invoke("You do not have enough money, your balance", this.sum);
                }
                else
                {
                    prtmsg.Invoke("You take money your balance", this.sum);
                }
            }
        }
    }
}