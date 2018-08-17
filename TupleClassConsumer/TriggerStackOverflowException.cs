using NamespaceWithSelfReferencingBaseClass;

public class TriggerStackOverflowException
{
    void Method()
    {
        // Directly reference the type. This causes a StackOverflowException.
        new SelfReferencingClassWithTuple();

        // You can also indirectly cause the compiler to load the type by triggering a
        // search for an extension method as long as the proper “using” is in place:
        //using NamespaceWithSelfReferencingBaseClass;
        //using System.Linq;
        //Enumerable.Empty<string>().Distinct();
    }
}
