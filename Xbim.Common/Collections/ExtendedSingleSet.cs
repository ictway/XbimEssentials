﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Xbim.Common.Collections
{
    public class ExtendedSingleSet<TInner, TOuter> : IItemSet<TOuter>
    {
        private TInner Inner {get { return _getter(); } set { _setter(value); }}
        private readonly Func<TInner> _getter;
        private readonly Action<TInner> _setter;
        private readonly IItemSet<TOuter> _extended;
        private readonly Func<TInner, TOuter> _toOut;
        private readonly Func<TOuter, TInner> _toIn;

        public ExtendedSingleSet(Func<TInner> getter, Action<TInner> setter, IItemSet<TOuter> extended, Func<TInner,TOuter> toOut, Func<TOuter, TInner> toIn)
        {
            _getter = getter;
            _setter = setter;
            _extended = extended;
            _toOut = toOut;
            _toIn = toIn;
        }

        public IEnumerator<TOuter> GetEnumerator()
        {
            return Inner == null ? 
                _extended.GetEnumerator() : 
                _extended.Concat(new [] {_toOut(Inner)}).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(TOuter item)
        {
            if (item == null)
                return;

            var inner = _toIn(item);
            if (Inner == null && inner != null)
            {
                Inner = inner;
                return;
            }

            _extended.Add(item);
        }

        public void Clear()
        {
            Inner = default(TInner);
            _extended.Clear();
        }

        public bool Contains(TOuter item)
        {
            if (item == null)
                return false;

            if (item.GetType().IsClass)
            {
                return item.Equals(Inner) || _extended.Contains(item);
            }

            var inner = _toIn(item);
            return inner.Equals(Inner) || _extended.Contains(item);
        }

        public void CopyTo(TOuter[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(TOuter item)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public int IndexOf(TOuter item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, TOuter item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public TOuter this[int index]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public event NotifyCollectionChangedEventHandler CollectionChanged;
        public event PropertyChangedEventHandler PropertyChanged;

        public IPersistEntity OwningEntity
        {
            get { throw new NotImplementedException(); }
        }

        public void AddRange(IEnumerable<TOuter> values)
        {
            throw new NotImplementedException();
        }

        public TOuter First
        {
            get { throw new NotImplementedException(); }
        }

        public TOuter FirstOrDefault()
        {
            throw new NotImplementedException();
        }

        public TOuter FirstOrDefault(Func<TOuter, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public TF FirstOrDefault<TF>(Func<TF, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TW> Where<TW>(Func<TW, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TO> OfType<TO>()
        {
            throw new NotImplementedException();
        }
    }

    
}
