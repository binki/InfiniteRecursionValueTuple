using InfiniteRecursionValueTuple;

namespace NamespaceWithSelfReferencingBaseClass
{
    ///
    public class SelfReferencingClassWithTuple
        : ClassWithTwoTypeParameters<SelfReferencingClassWithTuple, (string A, int B)>
    {
    }
}
