﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]
[assembly: global::System.Data.Objects.DataClasses.EdmRelationshipAttribute("Repositories.NorthwindModel", "FK_Products_Categories", "Categories", global::System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(NorthwindApp.Domain.Category), "Products", global::System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(NorthwindApp.Domain.Product))]

// Original file name:
// Generation date: 4/6/2009 4:56:42 PM
namespace NorthwindApp.Domain
{
    
    /// <summary>
    /// There are no comments for NorthwindEntities in the schema.
    /// </summary>
    public partial class NorthwindEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new NorthwindEntities object using the connection string found in the 'NorthwindEntities' section of the application configuration file.
        /// </summary>
        public NorthwindEntities() : 
                base("name=NorthwindEntities", "NorthwindEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new NorthwindEntities object.
        /// </summary>
        public NorthwindEntities(string connectionString) : 
                base(connectionString, "NorthwindEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new NorthwindEntities object.
        /// </summary>
        public NorthwindEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "NorthwindEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for Categories in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<Category> Categories
        {
            get
            {
                if ((this._Categories == null))
                {
                    this._Categories = base.CreateQuery<Category>("[Categories]");
                }
                return this._Categories;
            }
        }
        private global::System.Data.Objects.ObjectQuery<Category> _Categories;
        /// <summary>
        /// There are no comments for Products in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<Product> Products
        {
            get
            {
                if ((this._Products == null))
                {
                    this._Products = base.CreateQuery<Product>("[Products]");
                }
                return this._Products;
            }
        }
        private global::System.Data.Objects.ObjectQuery<Product> _Products;
        /// <summary>
        /// There are no comments for Categories in the schema.
        /// </summary>
        public void AddToCategories(Category category)
        {
            base.AddObject("Categories", category);
        }
        /// <summary>
        /// There are no comments for Products in the schema.
        /// </summary>
        public void AddToProducts(Product product)
        {
            base.AddObject("Products", product);
        }
    }
    /// <summary>
    /// There are no comments for Repositories.NorthwindModel.Category in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Identificador
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="Repositories.NorthwindModel", Name="Category")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Category : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new Category object.
        /// </summary>
        /// <param name="identificador">Initial value of Identificador.</param>
        /// <param name="categoryName">Initial value of CategoryName.</param>
        public static Category CreateCategory(int identificador, string categoryName)
        {
            Category category = new Category();
            category.Identificador = identificador;
            category.CategoryName = categoryName;
            return category;
        }
        /// <summary>
        /// There are no comments for Property Identificador in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int Identificador
        {
            get
            {
                return this._Identificador;
            }
            set
            {
                this.OnIdentificadorChanging(value);
                this.ReportPropertyChanging("Identificador");
                this._Identificador = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Identificador");
                this.OnIdentificadorChanged();
            }
        }
        private int _Identificador;
        partial void OnIdentificadorChanging(int value);
        partial void OnIdentificadorChanged();
        /// <summary>
        /// There are no comments for Property CategoryName in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string CategoryName
        {
            get
            {
                return this._CategoryName;
            }
            set
            {
                this.OnCategoryNameChanging(value);
                this.ReportPropertyChanging("CategoryName");
                this._CategoryName = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("CategoryName");
                this.OnCategoryNameChanged();
            }
        }
        private string _CategoryName;
        partial void OnCategoryNameChanging(string value);
        partial void OnCategoryNameChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this.ReportPropertyChanging("Description");
                this._Description = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("Description");
                this.OnDescriptionChanged();
            }
        }
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property Picture in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Picture
        {
            get
            {
                return global::System.Data.Objects.DataClasses.StructuralObject.GetValidValue(this._Picture);
            }
            set
            {
                this.OnPictureChanging(value);
                this.ReportPropertyChanging("Picture");
                this._Picture = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("Picture");
                this.OnPictureChanged();
            }
        }
        private byte[] _Picture;
        partial void OnPictureChanging(byte[] value);
        partial void OnPictureChanged();
        /// <summary>
        /// There are no comments for Products in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("Repositories.NorthwindModel", "FK_Products_Categories", "Products")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityCollection<Product> Products
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Product>("Repositories.NorthwindModel.FK_Products_Categories", "Products");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<Product>("Repositories.NorthwindModel.FK_Products_Categories", "Products", value);
                }
            }
        }
    }
    /// <summary>
    /// There are no comments for Repositories.NorthwindModel.Product in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Identificador
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="Repositories.NorthwindModel", Name="Product")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Product : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new Product object.
        /// </summary>
        /// <param name="identificador">Initial value of Identificador.</param>
        /// <param name="productName">Initial value of ProductName.</param>
        /// <param name="discontinued">Initial value of Discontinued.</param>
        public static Product CreateProduct(int identificador, string productName, bool discontinued)
        {
            Product product = new Product();
            product.Identificador = identificador;
            product.ProductName = productName;
            product.Discontinued = discontinued;
            return product;
        }
        /// <summary>
        /// There are no comments for Property Identificador in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int Identificador
        {
            get
            {
                return this._Identificador;
            }
            set
            {
                this.OnIdentificadorChanging(value);
                this.ReportPropertyChanging("Identificador");
                this._Identificador = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Identificador");
                this.OnIdentificadorChanged();
            }
        }
        private int _Identificador;
        partial void OnIdentificadorChanging(int value);
        partial void OnIdentificadorChanged();
        /// <summary>
        /// There are no comments for Property ProductName in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName
        {
            get
            {
                return this._ProductName;
            }
            set
            {
                this.OnProductNameChanging(value);
                this.ReportPropertyChanging("ProductName");
                this._ProductName = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("ProductName");
                this.OnProductNameChanged();
            }
        }
        private string _ProductName;
        partial void OnProductNameChanging(string value);
        partial void OnProductNameChanged();
        /// <summary>
        /// There are no comments for Property SupplierID in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<int> SupplierID
        {
            get
            {
                return this._SupplierID;
            }
            set
            {
                this.OnSupplierIDChanging(value);
                this.ReportPropertyChanging("SupplierID");
                this._SupplierID = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("SupplierID");
                this.OnSupplierIDChanged();
            }
        }
        private global::System.Nullable<int> _SupplierID;
        partial void OnSupplierIDChanging(global::System.Nullable<int> value);
        partial void OnSupplierIDChanged();
        /// <summary>
        /// There are no comments for Property QuantityPerUnit in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string QuantityPerUnit
        {
            get
            {
                return this._QuantityPerUnit;
            }
            set
            {
                this.OnQuantityPerUnitChanging(value);
                this.ReportPropertyChanging("QuantityPerUnit");
                this._QuantityPerUnit = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("QuantityPerUnit");
                this.OnQuantityPerUnitChanged();
            }
        }
        private string _QuantityPerUnit;
        partial void OnQuantityPerUnitChanging(string value);
        partial void OnQuantityPerUnitChanged();
        /// <summary>
        /// There are no comments for Property UnitPrice in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<decimal> UnitPrice
        {
            get
            {
                return this._UnitPrice;
            }
            set
            {
                this.OnUnitPriceChanging(value);
                this.ReportPropertyChanging("UnitPrice");
                this._UnitPrice = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("UnitPrice");
                this.OnUnitPriceChanged();
            }
        }
        private global::System.Nullable<decimal> _UnitPrice;
        partial void OnUnitPriceChanging(global::System.Nullable<decimal> value);
        partial void OnUnitPriceChanged();
        /// <summary>
        /// There are no comments for Property UnitsInStock in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<short> UnitsInStock
        {
            get
            {
                return this._UnitsInStock;
            }
            set
            {
                this.OnUnitsInStockChanging(value);
                this.ReportPropertyChanging("UnitsInStock");
                this._UnitsInStock = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("UnitsInStock");
                this.OnUnitsInStockChanged();
            }
        }
        private global::System.Nullable<short> _UnitsInStock;
        partial void OnUnitsInStockChanging(global::System.Nullable<short> value);
        partial void OnUnitsInStockChanged();
        /// <summary>
        /// There are no comments for Property UnitsOnOrder in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<short> UnitsOnOrder
        {
            get
            {
                return this._UnitsOnOrder;
            }
            set
            {
                this.OnUnitsOnOrderChanging(value);
                this.ReportPropertyChanging("UnitsOnOrder");
                this._UnitsOnOrder = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("UnitsOnOrder");
                this.OnUnitsOnOrderChanged();
            }
        }
        private global::System.Nullable<short> _UnitsOnOrder;
        partial void OnUnitsOnOrderChanging(global::System.Nullable<short> value);
        partial void OnUnitsOnOrderChanged();
        /// <summary>
        /// There are no comments for Property ReorderLevel in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<short> ReorderLevel
        {
            get
            {
                return this._ReorderLevel;
            }
            set
            {
                this.OnReorderLevelChanging(value);
                this.ReportPropertyChanging("ReorderLevel");
                this._ReorderLevel = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("ReorderLevel");
                this.OnReorderLevelChanged();
            }
        }
        private global::System.Nullable<short> _ReorderLevel;
        partial void OnReorderLevelChanging(global::System.Nullable<short> value);
        partial void OnReorderLevelChanged();
        /// <summary>
        /// There are no comments for Property Discontinued in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public bool Discontinued
        {
            get
            {
                return this._Discontinued;
            }
            set
            {
                this.OnDiscontinuedChanging(value);
                this.ReportPropertyChanging("Discontinued");
                this._Discontinued = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Discontinued");
                this.OnDiscontinuedChanged();
            }
        }
        private bool _Discontinued;
        partial void OnDiscontinuedChanging(bool value);
        partial void OnDiscontinuedChanged();
        /// <summary>
        /// There are no comments for Category in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("Repositories.NorthwindModel", "FK_Products_Categories", "Categories")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public Category Category
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Category>("Repositories.NorthwindModel.FK_Products_Categories", "Categories").Value;
            }
            set
            {
                ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Category>("Repositories.NorthwindModel.FK_Products_Categories", "Categories").Value = value;
            }
        }
        /// <summary>
        /// There are no comments for Category in the schema.
        /// </summary>
        [global::System.ComponentModel.BrowsableAttribute(false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityReference<Category> CategoryReference
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Category>("Repositories.NorthwindModel.FK_Products_Categories", "Categories");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<Category>("Repositories.NorthwindModel.FK_Products_Categories", "Categories", value);
                }
            }
        }
    }
}
