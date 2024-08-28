using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Holdsystemet
{
   

    internal class Hold
    {
        static void Start()
        {

            Dictionary<int, Studerende> My_dict1 = new Dictionary<int, Studerende>();
            
            //(4212, new Studerende();
            //My_dict1(2032, "student");
            //My_dict1(3050, "student");
        }

        #region Instance fields
        public string _type;
        public string _lokation;
        public string _betegnelse;
        int _optagelsesår;
        bool _vinteroptag;
        #endregion

        #region Constructor
        public Hold(string type, string lokation, string betegnelse, int optagelsesår, bool vinteroptag)
        {
            _type = type;
            _lokation = lokation;
            _betegnelse = betegnelse;
            _optagelsesår = optagelsesår;
            _vinteroptag = vinteroptag;
        }


        #endregion

        #region Properties
        public string Type
        {
            get { return _type; }
            set { _type = value; }


        }

        public string Lokation
        {
            get { return _lokation; }
            set { _lokation = value; }

        }

        public string Betegnelse
        {
            get { return _betegnelse; }
            set { _betegnelse = value; }

        }

        public int Optagelsesår
        {
            get { return _optagelsesår; }
            set { _optagelsesår = value; }


        }

        public bool Vinteroptag
        {
            get { return _vinteroptag; }

        }


        #endregion

        #region Methods

        public override string ToString()
        {
            return $"type :  {Type} - lokation :  {Lokation} - betegnelse : {Betegnelse} - optagelsesår : {Optagelsesår} - vinteroptag : {Vinteroptag}";


        }
        public void AdderStuderende(Studerende studerende)
        {
           

        }
        public void SletStuderende(int id)
        {

        }

        #endregion

    }
}
