using System;

using BookStoreBusinessLayer.BookStoreDSTableAdapters;

namespace BookStoreBusinessLayer
{
    public class CategoryBL
    {
        private CategoryTableAdapter categoryAdapter = null;

        protected CategoryTableAdapter Adapter
        {
            get
            {
                if (categoryAdapter == null)
                {
                    categoryAdapter = new CategoryTableAdapter();
                }
                return categoryAdapter;
            }
        }

        public BookStoreDS.CategoryDataTable GetData()
        {
            return Adapter.GetData();
        }

        public int Update(String name, String description,
                          int id)
        {
            return Adapter.Update(name, description, id);
        }

        public int Delete(int id)
        {
            return Adapter.Delete(id);
        }

        public int Insert(string name, string description)
        {
            /*try
            {*/
                return Adapter.Insert(name, description);
            /*}
            catch
            {
                System.Diagnostics.Debug.WriteLine("Oops, problem inserting the data.");
                return -1; 
            }*/
        }
    }
}
