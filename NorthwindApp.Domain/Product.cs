using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace NorthwindApp.Domain
{
    public partial class Product : IEntityWithId, IDataErrorInfo
    {

        string IDataErrorInfo.Error
        {
            get { return null; }
        }

        string IDataErrorInfo.this[string columnName]
        {
            get {
                switch (columnName.ToLower())
                {
                    case "productname":
                        if (string.IsNullOrEmpty(this.ProductName))
                            return Messages.MensagemCampoObrigatorio;
                        break;
                    default:
                        return null;
                }
                return null; 
            }
        }

    }
}
