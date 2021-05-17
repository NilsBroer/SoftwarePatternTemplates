using System;
using System.Collections.Generic;

namespace Namespace
{
    public abstract class Component
    {
        private List<Component> children = new List<Component>();

        public virtual void Add(Component component)
        {
            if (IsComposite()) children.Add(component);
            else throw new NotImplementedException();
        }

        public virtual void Remove(Component component)
        {
            if (IsComposite()) children.Remove(component);
            else throw new NotImplementedException();
        }

        public virtual bool IsComposite()
        {
            return GetType() == typeof(Composite);
        }
    }

    public class Leaf : Component
    {
        public override bool IsComposite()
        {
            return false;
        }
    }

    public class Composite : Component
    {
        private List<Component> children = new List<Component>();

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }

        public override bool IsComposite()
        {
            return true;
        }
    }

    public class FirstComposite : Composite
    {
        //TODO: Implement
    }

    public class SecondComposite : Composite
    {
        //TODO: Implement
    }

    public class FirstLeaf : Leaf
    {
        //TODO: Implement
    }

    public class SecondLeaf : Leaf
    {
        //TODO: Implement
    }
}