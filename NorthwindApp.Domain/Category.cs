using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace NorthwindApp.Domain
{
    public partial class Category : IEntityWithId, IDataErrorInfo
    {
        #region IDataErrorInfo Members

        string IDataErrorInfo.Error
        {
            get { return null; }
        }


        string IDataErrorInfo.this[string columnName]
        {
            get
            {
                switch (columnName.ToLower())
                {
                    case "categoryname":
                        if (string.IsNullOrEmpty(
                            this.CategoryName))
                            return Messages.MensagemCampoObrigatorio;
                        break;
                    case "description":
                        if (string.IsNullOrEmpty(this.Description))
                            return Messages.MensagemCampoObrigatorio;
                        break;
                    default:
                        return null;
                }
                return null;
            }
        }

        #endregion

    }
}

