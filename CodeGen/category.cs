using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Orioncod_ocstore_database
{
    #region Category
    public class Category
    {
        #region Member Variables
        protected int _id;
        protected int _code;
        protected string _name;
        protected string _description;
        protected int _is_system;
        protected int _is_active;
        protected string _search_index;
        protected int _parent_id;
        #endregion
        #region Constructors
        public Category() { }
        public Category(int code, string name, string description, int is_system, int is_active, string search_index, int parent_id)
        {
            this._code=code;
            this._name=name;
            this._description=description;
            this._is_system=is_system;
            this._is_active=is_active;
            this._search_index=search_index;
            this._parent_id=parent_id;
        }
        #endregion
        #region Public Properties
        public virtual int Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual int Code
        {
            get {return _code;}
            set {_code=value;}
        }
        public virtual string Name
        {
            get {return _name;}
            set {_name=value;}
        }
        public virtual string Description
        {
            get {return _description;}
            set {_description=value;}
        }
        public virtual int Is_system
        {
            get {return _is_system;}
            set {_is_system=value;}
        }
        public virtual int Is_active
        {
            get {return _is_active;}
            set {_is_active=value;}
        }
        public virtual string Search_index
        {
            get {return _search_index;}
            set {_search_index=value;}
        }
        public virtual int Parent_id
        {
            get {return _parent_id;}
            set {_parent_id=value;}
        }
        #endregion
    }
    #endregion
}