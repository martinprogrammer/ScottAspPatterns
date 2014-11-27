using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.LayerSupertype
{
    public abstract class EntityBase<T>
    {
        private T _id;
        private IList<string> _brokenRules = new List<string>();
        private bool _IdHasBeenSet = false;

        public EntityBase() { }
        
        public EntityBase(T id)
        {
            this.Id = id;
        }

        public T Id
        {
            get { return _id; }
            set
            {
                if (_IdHasBeenSet)
                    ThrowExceptionIfOverwritingAnId();

                _id = value;
                _IdHasBeenSet = true;

            }
        }

        private void ThrowExceptionIfOverwritingAnId()
        {
            throw new ApplicationException("You cannot change the id of an entity");
        }

        public bool isValid()
        {
            ClearCollectionOfBrokenRules();
            CheckForBrokenRules();
            return _brokenRules.Count() == 0;
        }

        protected abstract void CheckForBrokenRules();

        private void ClearCollectionOfBrokenRules()
        {
            _brokenRules.Clear();
        }

        IEnumerable<string> GetBrokenBusinessRules()
        {
            return _brokenRules;
        }

        protected void AddBrokenRule(string brokenRule)
        {
            _brokenRules.Add(brokenRule);
        }
    }
}