﻿using System.Collections;

namespace YellowOak.HTMLLexicAnalisys
{
    interface IAttributeList
    {
        public int Count { get; }
        public List<Attribute> GetAll { get; }
        public void Add(Attribute attribute);
        public void Clear();
        public Attribute? GetAttribute(string name);

    }

    internal class AttributeList: IAttributeList, IEnumerable<Attribute>
    {
        private readonly List<Attribute> _attributes = [];

        public List<Attribute> GetAll => _attributes;

        public int Count => _attributes.Count;

        public void Add(Attribute attribute)
        {
                _attributes.Add(attribute);
        }

        public void Clear()
        {
            _attributes.Clear();
        }

        public Attribute? GetAttribute(string name)
        {
            foreach (Attribute attribute in _attributes)
            {
                if (attribute.Name == name)
                {
                    return attribute;
                }
            }    
            return null;
        }

        public IEnumerator<Attribute> GetEnumerator()
        {
            return _attributes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }
    }
}