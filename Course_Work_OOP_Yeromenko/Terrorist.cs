using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work_OOP_Yeromenko
{
    public class Terrorist : Criminal
    {
        public Terrorist()
        {
            CriminalProfession = "Terrorist";

        }
    }
    public class Hacker : Criminal
    {
        public Hacker()
        {

            CriminalProfession = "Hacker";
        }
    }
    public class Murderer : Criminal
    {
        public Murderer()
        {
            CriminalProfession = "Murderer";
        }
    }
    public class Rapist : Criminal 
    {
        public Rapist()
        {
            CriminalProfession = "Rapist";

        }    
    }
    public class Robber : Criminal
    {
        public Robber()
        {
            CriminalProfession = "Robber";
        }
    }
    public class Hitman : Criminal
    {
        public Hitman()
        {
            CriminalProfession = "Hitman";
        }
    }
    public class Fraudster : Criminal
    {
        public Fraudster()
        {
            CriminalProfession = "Fraudster";
        }
    }
    public class DrugDealer : Criminal
    {
        public DrugDealer()
        {
            CriminalProfession = "Drugdealer";
        }
    }
    public class Kidnapper : Criminal
    {
        public Kidnapper()
        {
            CriminalProfession = "Kidnapper";
        }
    }
}
