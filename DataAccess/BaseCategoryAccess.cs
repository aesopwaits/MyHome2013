﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LocalTypes;
using MoreLinq;

namespace DataAccess
{
    public abstract class BaseCategoryAccess
    {
        #region Abstract Methods

        public abstract List<BaseCategory> LoadAll();

        internal abstract void UpdateDataBase(BaseCategory categoryTranslating);

        public abstract int AddNewCategory(string categoryName);

        #endregion

        #region Implemented Methods

        public bool Save(BaseCategory categoryToSave)
        {
            try
            {
                UpdateDataBase(categoryToSave);
                return true;
            }
            catch
            {
                return false;
            }
        }

        internal int GetNextId()
        {
            return this.LoadAll().MaxBy(ct => ct.Id).Id + 1;
        }

        #endregion
    }
}
