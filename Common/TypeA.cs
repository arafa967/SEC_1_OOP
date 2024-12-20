using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    // what can we write inside the name space ?
    //1-class 
    //2- struct
    //3- interface
    //4- Enum
//-----------------------------------------------
// allowed Access modifier inside the name space 
//1- internal(defualt Access modifier)
//2-public 
    public class TypeA
    {
        /*private*/ int X;
        internal int Y;
        public int Z;

        #region definitions 
        // whate you can write inside the class or Struct 
        //1-Attribute (filed * variable)
        //2- property (fullproperty - automatic property -indexer)
        //3-function (constructor - getter/setter - method)
        //4-Event
        //----------------------------------
        // allowed Access modifier inside the Struct 
        //1-privete
        //2-internanl
        //3-public
        //------------------------------------
        // Allowed  Access modifier inside the class
        // 1- private
        //2- private protected
        //3- protected
        //4- internal 
        //5- internal protected 
        //6- public 
        //--------------------------
        // what you can Write inside the interface
        //1- Signatuer for property 
        // 2- Signatuer for Method 
        //3- Default implemented Method 
        //----------------------------------
        // Default Access modifier inside the enterFace is Public 
        #endregion


    }
}
