using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holdsystemet
{
    public class Studerende
    {
       

           

        

        #region Instance fields
        int _id;
        public string _name;
        public string _adress;
        public string _cprnummer;



        #endregion

        #region Constructor
        public Studerende(int id, string name, string adress, string cprnummer) 
        { 
            _id = id;
            _name = name;
            _adress = adress;
            _cprnummer = cprnummer;
        
        
        }

      
       


        #endregion

        #region Properties
        public string Name
        { 
            get { return _name; } 
            set { _name = value; }
        
        
        
        }

        public string Adress 
        { 
            get { return _adress; } 
            set { _adress = value; }
        }

        public string Cprnummer 
        { 
            get {  return _cprnummer; } 
            set { _cprnummer = value; }
        }

        public int Id 
        { 
            get { return _id; } 
            set { _id = value; }
        
        
        
        }


        #endregion

        #region Methods


        public override string ToString()
        {
            return $"name : {Name} - adress : {Adress} - cprnummer : {Cprnummer} - id : {Id}";


        }

       
        #endregion










    }
}
