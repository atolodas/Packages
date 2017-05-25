/// SYNTAX TEST "Packages/C#/C#.sublime-syntax"

// A skeleton of a C# program
using System;

namespace YourNamespace
///<- storage.type.namespace
///        ^ entity.name.namespace
{
///<- punctuation.section.block.begin
    class YourClass
/// ^ storage.type.class
///        ^ entity.name.class
    {
        Int x;
///     ^^^ support.type
///         ^ variable.other.member
        Int x0 = 0, y0 = 0;
///      ^ support.type
///         ^ variable.other.member
///            ^ keyword.operator.assignment
///               ^ punctuation.separator
///                  ^ variable.other.member
///                    ^ keyword.operator.assignment

        [ServiceBehavior(Namespace = "http://test/", InstanceContextMode = InstanceContextMode.PerCall)]
///                      ^ variable.parameter
///                                ^ keyword.operator.assignment
///                                  ^^^^^^^^^^^^^^ string.quoted.double
///                                                ^ punctuation.separator
///                                                  ^ variable.parameter
///                                                                      ^ keyword.operator.assignment
///                                                                        ^ - variable.parameter
        public Int YourProperty {
///     ^ storage.modifier
///            ^^^ support.type
///                  ^ variable.other.member
///                             ^ meta.property punctuation.section.block.begin
            get {return x;}
///         ^^^^^^^^^^^^^^^ meta.property meta.method
///          ^ storage.type.function.accessor.get
///             ^^^^^^^^^^^ meta.property meta.method.body meta.block
///             ^ punctuation.section.block.begin
///                      ^ punctuation.terminator
///                       ^ punctuation.section.block.end
            set {x = value;}
///         ^^^^^^^^^^^^^^^^ meta.property meta.method
///          ^ storage.type.function.accessor.set
///             ^^^^^^^^^^^^ meta.property meta.method.body meta.block
///             ^ punctuation.section.block.begin
///              ^ variable.other
///                    ^ variable.language
///                       ^ punctuation.terminator
///                        ^ punctuation.section.block.end
        }
///     ^ meta.property punctuation.section.block.end

        public bool IsConst(Type value) => this is Const && (this as Const).Value.Equals(value);
///                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^  meta.method
///                 ^^^^^^^ entity.name.function
///                        ^^^^^^^^^^^^ meta.method.parameters
///                        ^ punctuation.section.parameters.begin
///                         ^^^^ support.type
///                              ^^^^^ variable.parameter
///                                   ^ punctuation.section.parameters.end
///                                     ^^ storage.type.function
///                                        ^^^^ variable.language
///                                             ^^ keyword.operator.reflection
///                                                ^^^^^ support.type
///                                                      ^^ keyword.operator
///                                                         ^^^^^^^^^^^^^^^ meta.group
///                                                         ^ punctuation.section.group.begin
///                                                          ^^^^ variable.language
///                                                               ^^ keyword.operator.reflection
///                                                                  ^^^^^ support.type
///                                                                       ^ punctuation.section.group.end
///                                                                        ^ punctuation.accessor
///                                                                              ^ punctuation.accessor
///                                                                               ^^^^^^^^^^^^^ meta.function-call
///                                                                               ^^^^^^ variable.function
///                                                                                     ^^^^^^^ meta.group
///                                                                                     ^ punctuation.section.group.begin
///                                                                                      ^^^^^ variable.language
///                                                                                           ^ punctuation.section.group.end
///                                                                                            ^ punctuation.terminator

        public bool IsZero => IsConst(Numeric<Type>.Zero);
///                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.property
///                        ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.method
///                  ^ variable.other.member
///                        ^^ storage.type.function.accessor.get
///                           ^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.function-call
///                                   ^^^^^^^ support.type
///                                          ^^^^^^ meta.generic
///                                          ^ punctuation.definition.generic.begin
///                                           ^^^^ support.type
///                                               ^ punctuation.definition.generic.end

        public bool InlineProperty {get; private set; } = false;
///                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.property
///                 ^^^^^^^^^^^^^^ variable.other.member
///                                ^^^^^^^^^^^^^^^^^^^^ meta.property meta.block
///                                 ^^^ storage.type.function.accessor.get
///                                      ^^^^^^^ storage.modifier.access
///                                              ^^^ storage.type.function.accessor.set
///                                                     ^ keyword.operator.assignment
///                                                       ^^^^^ constant.language

        public new bool NewMethod() => false;
///            ^^^ storage.modifier
///                ^^^^ storage.type
///                     ^^^^^^^^^^^^^^^^^^^^ meta.method
///                     ^^^^^^^^^ entity.name.function
///                              ^^ meta.method.parameters
///                                 ^^ storage.type.function
///                                    ^^^^^ constant.language
    }

    struct YourStruct
/// ^^^^^^^^^^^^^^^^^ meta.struct
/// ^ storage.type.struct
///         ^ entity.name.struct
    {
///^^ meta.struct
//  ^ meta.block punctuation.section.block.begin
    }
///^^ meta.struct meta.block
//  ^ punctuation.section.block.end

    interface IYourInterface
/// ^^^^^^^^^^^^^^^^^^^^^^^^ meta.interface
/// ^ storage.type.interface
///           ^ entity.name.interface
    {
///^^ meta.interface
//  ^ meta.block punctuation.section.block.begin
    }
///^^ meta.interface meta.block
//  ^ punctuation.section.block.end

    delegate FooBar YourDelegate(int a);
/// ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.delegate
///  ^ storage.type.delegate
///           ^ support.type
///                  ^ variable.other.member.delegate
///                             ^^^^^^^ meta.delegate.parameters
///                              ^ storage.type
///                                  ^ variable.parameter
///                                    ^ punctuation.terminator

    enum YourEnum
/// ^^^^^^^^^^^^^ meta.enum
/// ^ storage.type.enum
///        ^ entity.name.enum
    {
///^^ meta.enum
/// ^ meta.block punctuation.section.block.begin
/// ^ - meta.enum meta.enum
        A, B
///     ^ constant.other.enum
    };
///^^ meta.enum meta.block
/// ^ punctuation.section.block.end
///  ^ punctuation.terminator

    public enum Things
    {
        [Stuff("1")]
///     ^^^^^^^^^^^^ meta.annotation
        Item1,
///     ^ constant.other.enum
        Item2,
        [Stuff]
///     ^^^^^^^ meta.annotation
        Item3
    }

    namespace YourNestedNamespace
/// ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.namespace meta.namespace
///     ^ storage.type.namespace
///             ^ entity.name.namespace
    {
///^^ meta.namespace
/// ^ meta.block punctuation.section.block.begin
        struct YourStruct
/// ^^^^^^^^^^^^^^^^^^^^^ meta.namespace
///     ^^^^^^^^^^^^^^^^^ meta.struct
///      ^ storage.type.struct
///              ^ entity.name.struct
        {
///     ^ meta.struct meta.block punctuation.section.block.begin
        }
///     ^ meta.struct meta.block punctuation.section.block.end
    }
/// ^ meta.namespace meta.block meta.namespace meta.block punctuation.section.block.end

    class InheritingSomething: IYourInterface
/// ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.class
/// ^ storage.type.class
///       ^ entity.name.class
///                          ^ punctuation.separator
///                            ^ entity.other.inherited-class
    {
///^^ meta.class
/// ^ meta.block punctuation.section.block.begin
    }
///^^ meta.class meta.block
/// ^ punctuation.section.block.end

    class WithGeneric<T1, T2> where T1: IEnumerable<T2> {}
/// ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.class
///                  ^^^^^^^^ meta.generic
///                  ^ punctuation.definition.generic.begin
///                     ^ punctuation.separator.type
///                         ^ punctuation.definition.generic.end
///                             ^ storage.modifier
///                                 ^^ support.type
///                                         ^ entity.other.inherited-class
///                                                ^^^^ meta.generic
///                                                ^  punctuation.definition.generic.begin
///                                                 ^^  support.type
///                                                   ^  punctuation.definition.generic.end

namespace TestNamespace.Test
{
    using NodeName = SomeNamespace.SomeClass;

    public class Derived : Base
    {
        public Derived(DateTime exportDate) : base(exportDate) {
///            ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.method
///            ^^^^^^^ entity.name.function.constructor
///                                         ^^^^^^^^^^^^^^^^^^ meta.method.constructor
///                                           ^^^^ variable.language
///                                               ^^^^^^^^^^^^ meta.group
            for (int i = 0; i < items.Count; ++i)
///         ^ keyword.control.loop
///         ^^^^ - meta.group
///             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.group
///             ^ punctuation.section.group.begin
///              ^^^ storage.type
///                  ^ variable.other
///                    ^ keyword.operator.assignment
///                       ^ punctuation.terminator
///                         ^ variable.other
///                           ^ keyword.operator
///                                        ^ punctuation.terminator
///                                          ^^ keyword.operator
///                                            ^ variable.other
///                                             ^ punctuation.section.group.end
            {}
///         ^^ meta.method meta.block meta.block
///         ^ punctuation.section.block.begin
///          ^ punctuation.section.block.end
            foreach (int test in collection)
///         ^ keyword.control.loop
///         ^^^^^^^^ - meta.group
///                 ^^^^^^^^^^^^^^^^^^^^^^^^ meta.group
///                 ^ punctuation.section.group.begin
///                  ^^^ storage.type
///                      ^^^^ variable.other
///                           ^^ keyword.control.flow
///                              ^^^^^^^^^^ variable.other
///                                        ^ punctuation.section.group.end
            {}
///         ^^ meta.method meta.block meta.block
///         ^ punctuation.section.block.begin
///          ^ punctuation.section.block.end

            if (true)
///         ^ keyword.control
///            ^^^^^^ meta.group
///            ^ punctuation.section.group.begin
///                 ^ punctuation.section.group.end
                a = 5;
///                 ^ constant.numeric

            if (false) {
///         ^ keyword.control
///            ^^^^^^^ meta.group
///            ^ punctuation.section.group.begin
///                  ^ punctuation.section.group.end
///                    ^ meta.method meta.block meta.block punctuation.section.block.begin

            }
///         ^ meta.method meta.block meta.block punctuation.section.block.end

            if (false) {
///         ^ keyword.control
///            ^^^^^^^ meta.group
///            ^ punctuation.section.group.begin
///                  ^ punctuation.section.group.end
///                    ^ meta.method meta.block meta.block punctuation.section.block.begin

            } else {
///         ^ meta.method meta.block meta.block punctuation.section.block.end
///           ^ keyword.control
///                ^ meta.method meta.block meta.block punctuation.section.block.begin

            }
///         ^ meta.method meta.block meta.block punctuation.section.block.end

            switch (foo) {
///         ^ keyword.control
///                ^^^^^ meta.group
///                ^ punctuation.section.group.begin
///                 ^^^ variable.other
///                    ^ punctuation.section.group.end
///                      ^ meta.method meta.block meta.block punctuation.section.block.begin
                case 1:
///             ^ keyword.control
///                  ^ constant.numeric
///                   ^ punctuation.separator
                    do_something();
///                 ^ variable.function
                    break;
///                 ^ keyword.control
                case BLBodyBattleLibrary.ContextType.TapUp:
///             ^^^^ keyword.control.switch.case
///                  ^^^^^^^^^^^^^^^^^^^ variable.other
///                                     ^ punctuation.accessor.dot
///                                      ^^^^^^^^^^^ variable.other
///                                                 ^ punctuation.accessor.dot
///                                                  ^^^^^ constant.other
///                                                       ^ punctuation.separator.case-statement
                case BindingFlags.Static:
///             ^^^^ keyword.control.switch.case
///                  ^^^^^^^^^^^^ variable.other
///                              ^ punctuation.accessor.dot
///                               ^^^^^^ constant.other
///                                     ^ punctuation.separator.case-statement
                case test:
///             ^^^^ keyword.control.switch.case
///                  ^^^^ constant.other
///                      ^ punctuation.separator.case-statement
                case this.test;
///             ^^^^ keyword.control.switch.case
///                  ^^^^ variable.language
///                      ^ punctuation.accessor.dot
                case 1*2:
///             ^^^^ keyword.control.switch.case
///                  ^ constant.numeric
///                   ^ keyword.operator
///                    ^ constant.numeric
///                     ^ punctuation.separator.case-statement
                case bar("hello"):
///             ^^^^ keyword.control.switch.case
///                  ^^^ variable.function
///                     ^ punctuation.section.group.begin
///                      ^^^^^^^ string.quoted.double
///                             ^ punctuation.section.group.end
///                              ^ punctuation.separator.case-statement
                    break;
                default:
///             ^ keyword.control
///                    ^ punctuation.separator
                    do_something_else();
///                 ^ variable.function
                    break;
///                 ^ keyword.control
            }
///         ^ meta.method meta.block meta.block punctuation.section.block.end

            while (true) {
///         ^ keyword.control
///               ^^^^^ meta.group
///               ^ punctuation.section.group.begin
///                ^^^^ constant.language
///                    ^ punctuation.section.group.end
///                      ^ meta.method meta.block meta.block punctuation.section.block.begin
                if (!something())
///             ^ keyword.control
///                ^^^^^^^^^^^^^^ meta.group
                    break;
            }
///         ^ meta.method meta.block meta.block punctuation.section.block.end

            do {
///         ^ keyword.control
///            ^ meta.method meta.block meta.block punctuation.section.block.begin
                something();
            } while (true);
///         ^ meta.method meta.block meta.block punctuation.section.block.end
///           ^ keyword.control
///                 ^^^^^ meta.group
///                 ^ punctuation.section.group.begin
///                  ^^^^ constant.language
///                      ^ punctuation.section.group.end

            try {
///         ^ keyword.control
///             ^ meta.method meta.block meta.block punctuation.section.block.begin
            } catch (ArgumentException e)
///         ^ meta.method meta.block meta.block punctuation.section.block.end
///           ^ keyword.control
///                 ^^^^^^^^^^^^^^^^^^^^^ meta.group
///                 ^ punctuation.section.group.begin
///                                     ^ punctuation.section.group.end
            {
///         ^ meta.method meta.block meta.block punctuation.section.block.begin
            }
///         ^ meta.method meta.block meta.block punctuation.section.block.end

            try {
///         ^ keyword.control
///             ^ meta.method meta.block meta.block punctuation.section.block.begin
            } catch (ArgumentException e) when (e.ParamName == "foo")
///         ^ meta.method meta.block meta.block punctuation.section.block.end
///           ^ keyword.control
///                 ^^^^^^^^^^^^^^^^^^^^^ meta.group
///                 ^ punctuation.section.group.begin
///                                     ^ punctuation.section.group.end
///                                       ^ keyword.control
///                                            ^^^^^^^^^^^^^^^^^^^^^^ meta.group
///                                            ^ punctuation.section.group.begin
///                                                         ^^ keyword.operator
///                                                            ^^^^ string.quoted.double
///                                                                 ^ punctuation.section.group.end
            {
///         ^ meta.method meta.block meta.block punctuation.section.block.begin
            }
///         ^ meta.method meta.block meta.block punctuation.section.block.end
            finally {
///         ^ keyword.control
///                 ^ meta.method meta.block meta.block punctuation.section.block.begin
                var foo = "";
///             ^ storage.type.variable
///                       ^^ string.quoted.double
            }
///         ^ meta.method meta.block meta.block punctuation.section.block.end
        }

        public virtual void Instantiate<T>(string componentId, out T component)
///                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.method
///     ^ storage.modifier
///            ^ storage.modifier
///                    ^ storage.type
///                         ^ entity.name.function
///                         ^^^^^^^^^^^ - meta.generic
///                                    ^^^ meta.generic
///                                       ^ punctuation.section.parameters.begin
///                                        ^^^^^^ storage.type
///                                               ^^^^^^^^^^^ variable.parameter
///                                                          ^ punctuation.separator
///                                                            ^^^ storage.modifier
///                                                                ^ support.type
///                                                                  ^^^^^^^^^ variable.parameter

            where T : BaseComponent
///         ^ storage.modifier
///               ^ support.type
///                 ^ punctuation.separator
///                   ^ entity.other.inherited-class
        {
            var test = "Test";
///         ^ storage.type.variable
///             ^ variable.other
///                  ^ keyword.operator.assignment
///                    ^ string.quoted.double
///                          ^ punctuation.terminator
        }
    }
}


    class YourMainClass
/// ^^^^^^^^^^^^^^^^^^^ meta.class
///   ^ storage.type.class
///          ^ entity.name.class
    {
/// ^ meta.class meta.block punctuation.section.block.begin

        public DateTime test1;
///     ^ storage.modifier
///            ^^^^^^^^ support.type
///                     ^^^^^ variable.other.member

        public DateTime? test2;
///     ^ storage.modifier
///            ^^^^^^^^ support.type
///                    ^ storage.type.nullable
///                      ^^^^^ variable.other.member

        private const string _bar = "bar";
///     ^ storage.modifier
///             ^^^^^ storage.modifier
///                   ^ storage.type
///                          ^^^^ variable.other.member
///                               ^ keyword.operator.assignment
///                                 ^^^^^ string.quoted.double
///                                 ^ punctuation.definition.string.begin
///                                     ^ punctuation.definition.string.end

        static void Main(string[] args)
///                 ^^^^^^^^^^^^^^^^^^^ meta.method
///                      ^^^^^^   storage.type
///                            ^^ meta.brackets
///                            ^ punctuation.section.brackets.begin
///                             ^ punctuation.section.brackets.end
///                               ^^^^ variable.parameter
        {
///     ^ meta.class meta.block meta.method meta.block punctuation.section.block.begin
            //Your program starts here...
            var f = 1e-3f;
///         ^^^ storage.type.variable
///             ^ variable.other
///                 ^^^^ constant.numeric
///                     ^ storage.type.numeric
            var l = 11545L;
///         ^^^ storage.type.variable
///             ^ variable.other
///                 ^^^^^ constant.numeric
///                      ^ storage.type.numeric
            var d = 11545D;
///         ^^^ storage.type.variable
///             ^ variable.other
///                 ^^^^^ constant.numeric
///                      ^ storage.type.numeric
            int x = 1, y = 0;
///         ^^^ storage.type
///             ^ variable.other
///               ^ keyword.operator.assignment
///                 ^ constant.numeric
///                  ^ punctuation.separator
///                    ^ variable.other
///                      ^ keyword.operator.assignment
///                        ^ constant.numeric
///                         ^ punctuation.terminator
            value = x;
///         ^^^^^ variable.language
///               ^ keyword.operator.assignment
///                 ^ variable.other
///                  ^ punctuation.terminator
            const int x = 1;
///         ^ storage.modifier
///               ^ storage.type
///                   ^ variable.other
///                     ^ keyword.operator.assignment
///                       ^ constant.numeric
///                        ^ punctuation.terminator
        }
///     ^ punctuation.section.block.end

        private void MethodWith1Default(int max, string path = null) { }
///        ^ storage.modifier
///                  ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.method
///                  ^ entity.name.function
///                                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.method.parameters
///                                     ^^^ storage.type
///                                         ^^^ variable.parameter
///                                            ^ punctuation.separator
///                                              ^^^^^^ storage.type
///                                                     ^^^^ variable.parameter
///                                                          ^ keyword.operator.assignment
///                                                            ^^^^ constant.language

        internal void MethodWith2Default(int max = -1, string path = null){ }
///        ^ storage.modifier
///                   ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.method
///                   ^ entity.name.function
///                                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.method.parameters
///                                      ^^^ storage.type
///                                          ^^^ variable.parameter
///                                              ^ keyword.operator.assignment
///                                                 ^ constant.numeric
///                                                  ^ punctuation.separator
///                                                    ^^^^^^ storage.type
///                                                           ^^^^ variable.parameter
///                                                                ^ keyword.operator.assignment
///                                                                  ^^^^ constant.language

        partial void MethodWithTypeParam<T>(T x){ do_something(); }
///        ^ storage.modifier
///                      ^^^ entity.name.function
///                                     ^^^ meta.generic
///                                     ^ punctuation.definition.generic.begin
///                                      ^ support.type
///                                         ^ support.type
///                                           ^ variable.parameter
///                                               ^ variable.function

        List<List<List<List<float>>>> reallyNestedTypes;
///     ^^^^ support.type
///         ^^^^^^^^^^^^^^^^^^^^^^^^^ meta.generic
///          ^^^^ support.type
///              ^^^^^^^^^^^^^^^^^^^ meta.generic meta.generic
///               ^^^^ support.type
///                   ^^^^^^^^^^^^^ meta.generic meta.generic meta.generic
///                    ^^^^ support.type
///                        ^^^^^^^ meta.generic meta.generic meta.generic meta.generic
///                         ^^^^^ storage.type
///                                   ^ variable.other.member

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
///                      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.method
///                      ^^^^^^^^^^^ entity.other.inherited-class
///                                 ^^^^^ meta.generic
///                                  ^^^ storage.type
///                                       ^^^^ entity.name.function
        {
            return new MyCustomIterator(this);
///                ^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.instance
///                ^ keyword.operator.new
///                    ^^^^^^^^^^^^^^^^ support.type
///                                    ^^^^^^ meta.group
///                                    ^ punctuation.section.group.begin
///                                     ^^^^ variable.language
///                                         ^ punctuation.section.group.end
        }

        IEnumerable<int> Traverse()
        {
            yield return 7;
///         ^ keyword.control.flow.return
///                ^ keyword.control.flow.return
            yield return 42;
            yield return 314;
        }

        List<int>.this[int key]{ get; set; }
///     ^ support.type
///         ^^^^^ meta.generic
///         ^ punctuation.definition.generic.begin
///             ^ punctuation.definition.generic.end
///              ^ punctuation.accessor
///               ^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.property
///               ^^^^^^^^^^^^^^^ - meta.method
///                                  ^ - meta.method
///                                       ^^^ - meta.method
///               ^^^^ variable.language
///                   ^^^^^^^^^ meta.brackets
///                   ^ punctuation.section.brackets.begin
///                           ^ punctuation.section.brackets.end
///                    ^^^ storage.type
///                        ^^^ variable.parameter
///                              ^^^ storage.type.function.accessor
///                                   ^^^ storage.type.function.accessor


        /////////////////////////////
        // methods with attributes //
        /////////////////////////////

        [Route("api/helloworld")]
///     ^^^^^^^^^^^^^^^^^^^^^^^^^ meta.annotation
///     ^ punctuation.definition.annotation.begin
///      ^^^^^ variable.annotation
///           ^^^^^^^^^^^^^^^^^^ meta.group
///           ^ punctuation.section.group.begin
///            ^^^^^^^^^^^^^^^^ string
///                            ^ punctuation.section.group.end
///                             ^ punctuation.definition.annotation.end
        string Get([FromUri] string name) => $"Hello {name}";
///                ^^^^^^^^^ meta.annotation
///                ^ punctuation.definition.annotation.begin
///                 ^^^^^^^ variable.annotation
///                        ^ punctuation.definition.annotation.end
///                           ^^^^^   storage.type

        // examples from: https://msdn.microsoft.com/en-us/library/mt653979.aspx
        // applies to method
        [method: SomeAttr]
///     ^^^^^^^^^^^^^^^^^^ meta.annotation
///     ^ punctuation.definition.annotation.begin
///      ^^^^^^  storage.modifier.target
///            ^ punctuation.separator
///              ^^^^^^^^ variable.annotation
///                      ^ punctuation.definition.annotation.end
        int Method2() { return 0; }

        // applies to return value
        [return: SomeAttr]
///     ^^^^^^^^^^^^^^^^^^ meta.annotation
///     ^ punctuation.definition.annotation.begin
///      ^^^^^^  storage.modifier.target
///            ^ punctuation.separator
///              ^^^^^^^^ variable.annotation
///                      ^ punctuation.definition.annotation.end
        int Method3() { return 0; }

        [AcceptVerbs(HttpVerbs.Post)]
///     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.annotation
///      ^^^^^^^^^^^ variable.annotation
///                 ^ punctuation.section.group.begin
///                                ^ punctuation.section.group.end
        [ValidateAntiForgeryToken]
///     ^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.annotation
///      ^^^^^^^^^^^^^^^^^^^^^^^^ variable.annotation
        [JsonHandleError]
///     ^^^^^^^^^^^^^^^^^ meta.annotation
///      ^^^^^^^^^^^^^^^ variable.annotation
        public virtual ActionResult Process([ModelBinder(typeof(MyModelBinder))]
///                                 ^ entity.name.function
///                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.annotation
///                                                     ^^^^^^^^^^^^^^^^^^^^^^^ meta.group
///                                                      ^^^^^^ keyword.operator
///                                                            ^^^^^^^^^^^^^^^ meta.group meta.group
///                                                             ^^^^^^^^^^^^^ support.type
                                            [Bind(Prefix = "MyContent")] MyProcessModel model)
///                                         ^^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.annotation
///                                          ^^^^ variable.annotation
///                                              ^^^^^^^^^^^^^^^^^^^^^^ meta.group
///                                               ^^^^^^ variable.parameter
///                                                      ^ keyword.operator.assignment
///                                                        ^^^^^^^^^^^ string.quoted.double
        {
        }

        int Method4 => 5;
///     ^^^ storage.type
///         ^^^^^^^ variable.other.member
///                 ^^^^ meta.method
///                 ^^ storage.type.function
///                    ^ constant.numeric
///                     ^ punctuation.terminator

        delegate int del(int i);
///     ^^^^^^^^^^^^^^^^^^^^^^^ meta.delegate
///     ^ storage.type.delegate
///              ^ storage.type
///                  ^ variable.other.member.delegate
///                     ^^^^^^^ meta.delegate.parameters
///                      ^ storage.type
///                          ^ variable.parameter

        public delegate TOutput Converter<TInput, TOutput> (TInput from);
///     ^ storage.modifier
///            ^ storage.type.delegate
///                     ^ support.type
///                             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.delegate
///                             ^ variable.other.member.delegate
///                                      ^^^^^^^^^^^^^^^^^ meta.generic
///                                      ^ punctuation.definition.generic.begin
///                                       ^^^^^^ support.type
///                                             ^ punctuation.separator
///                                               ^^^^^^^ support.type
///                                                      ^ punctuation.definition.generic.end
///                                                        ^^^^^^^^^^^^^ meta.delegate.parameters
///                                                        ^ - meta.delegate meta.delegate
///                                                         ^ support.type
///                                                                ^ variable.parameter

        void CodeContainingLambdas(){

            del square = x => x * x;
///         ^^^ support.type
///              ^^^ variable.other
///                    ^ keyword.operator.assignment
///                        ^^^^^^^^ meta.function.anonymous
///                        ^^ storage.type.function.lambda
            Func<float, float> times2 = x => x + x;
///         ^^^ support.type
///                            ^^^ variable.other
///                                   ^ keyword.operator.assignment
///                                     ^^^^^^^^^^ meta.function.anonymous
///                                       ^^ storage.type.function.lambda

        }

        void CodeContainingConstructors(){
            var array = new []{ "foo" };
///                     ^^^^^^^^^^^^^^^ meta.instance
///                         ^^ meta.brackets.cs
///                           ^^^^^^^^^ meta.braces
///                           ^ punctuation.section.braces.begin
///                                   ^ punctuation.section.braces.end

            var arrayWithType = new string<Foo>[] { "foobar" };
///                             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.instance
///                                               ^^^^^^^^^^^^ meta.braces
///                                               ^ punctuation.section.braces.begin
///                                                          ^ punctuation.section.braces.end

            var list = new List<Foo> { "coconuts", "horses" };
///                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.instance
///                                  ^^^^^^^^^^^^^^^^^^^^^^^^ meta.braces
///                                  ^ punctuation.section.braces.begin
///                                                         ^ punctuation.section.braces.end
            var dictionary = new Dictionary<string, string>
///                          ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.instance
            {
///         ^ meta.instance meta.braces punctuation.section.braces.begin
                ["woman"] = "floating",
                ["floating"] = "wood"
            };
///         ^ meta.instance meta.braces punctuation.section.braces.end

            var anonymous = new {
///                         ^^^^^ meta.instance
///                             ^ meta.class.body punctuation.section.block.begin
                Wood = "burning",
///             ^^^^ variable.other.member
///                  ^ keyword.operator.assignment
///                    ^^^^^^^^^ string.quoted.double
///                             ^ punctuation.separator
                Burning = "sorcerer"
///             ^^^^^^^ variable.other.member
///                     ^ keyword.operator.assignment
///                       ^^^^^^^^^^ string.quoted.double
            };
///         ^ meta.instance meta.class.body punctuation.section.block.end

            var anonArray = new[]
///                         ^^^^^ meta.instance
///                            ^^ meta.brackets
            {
///         ^ meta.instance meta.braces punctuation.section.braces.begin
                new { name = "apple", diam = 4 },
///                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.class.body.anonymous
///                 ^punctuation.section.block.begin
///                   ^^^^ variable.other.member
///                        ^ keyword.operator.assignment
///                          ^^^^^^^ string.quoted.double
///                                 ^ punctuation.separator
///                                   ^^^^ variable.other.member
///                                        ^ keyword.operator.assignment
///                                          ^ constant.numeric
///                                            ^ punctuation.section.block.end
                new { name = "grape", diam = 1 }
///                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.class.body.anonymous
///                 ^ punctuation.section.block.begin
///                   ^^^^ variable.other.member
///                        ^ keyword.operator.assignment
///                          ^^^^^^^ string.quoted.double
///                                 ^ punctuation.separator
///                                   ^^^^ variable.other.member
///                                        ^ keyword.operator.assignment
///                                          ^ constant.numeric
///                                            ^ punctuation.section.block.end
            };
///         ^ meta.instance meta.braces punctuation.section.braces.end

            new System.Drawing.Point(6, 11) { X = 5, Y = 10 };
///             ^^^^^^ support.type
///                   ^ punctuation
///                    ^^^^^^^ support.type
///                           ^ punctuation
///                            ^^^^^ support.type
///                                 ^ punctuation.section.group.begin
///                                  ^ constant.numeric
///                                   ^ punctuation.separator.argument
///                                     ^^ constant.numeric
///                                       ^ punctuation.section.group.end
///                                         ^ punctuation.section.braces.begin
///                                           ^ variable.other
///                                             ^ keyword.operator.assignment
///                                               ^ constant.numeric
///                                                ^ punctuation.separator
///                                                  ^ variable.other
///                                                    ^ keyword.operator.assignment
///                                                      ^^ constant.numeric
///                                                         ^ punctuation.section.braces.end
///                                                          ^ punctuation.terminator.statement
            new System.Drawing.Point(6, 11)
                { X = 5, Y = 10 };
///             ^ punctuation.section.braces.begin
///               ^ variable.other
///                 ^ keyword.operator.assignment
///                   ^ constant.numeric
///                    ^ punctuation.separator
///                      ^ variable.other
///                        ^ keyword.operator.assignment
///                          ^^ constant.numeric
///                             ^ punctuation.section.braces.end
///                              ^ punctuation.terminator.statement
        }
///     ^ punctuation.section.block

        void TestMethod(int argument) {
            if (argument <= 0)
                throw new ArgumentException("Value must be positive", nameof(argument));
///                                                                   ^ keyword.other
///                                                                          ^ variable.other
            nameof(TestMethod);
///         ^ keyword.other
///                ^ support.type
            nameof(int);
///         ^ keyword.other
///                ^ storage.type
            nameof(YourNamespace<Foo>.foo);
///         ^ keyword.other
///                ^ support.type
///                             ^^^^^ meta.generic
///                                  ^ punctuation.accessor
///                                   ^ variable.other
        }

        #region Empty region 01 // not a comment !
///     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ meta.preprocessor
///     ^^^^^^^  keyword.other.preprocessor
///             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ entity.name.section
///                             ^^^^^^^ - comment

        #endregion Empty region 01
///     ^^^^^^^^^^  keyword.other.preprocessor
///                ^^^^^^^^^^^^^^^ variable.other.section
    }
/// ^ punctuation.section.block.end


    void TestMe () {
        a = b => b * 2;
///           ^^ storage.type.function.lambda
///           ^^^^^^^^ meta.function.anonymous
///                   ^ punctuation.terminator.statement - meta.function.anonymous

        try
///     ^^^ keyword.control.trycatch.try
        {

        }
        catch (InvalidOperationException ex)
///     ^^^^^ keyword.control.trycatch.catch
        {

        }
        finally
///     ^^^^^^^ keyword.control.trycatch.finally
        {

        }

        a = b => { return b * 2; };
///           ^^ meta.function.anonymous storage.type.function.lambda
///              ^ meta.function.anonymous punctuation.section.block.begin
///                              ^ punctuation.section.block.end
///                               ^ punctuation.terminator.statement - meta.function.anonymous

        try
///     ^^^ keyword.control.trycatch.try
        {

        }
        catch (InvalidOperationException ex)
///     ^^^^^ keyword.control.trycatch.catch
        {

        }
        finally
///     ^^^^^^^ keyword.control.trycatch.finally
        {
        }

        a = (b, c) => { return b * c; };
///          ^ variable.parameter
///           ^ punctuation.separator
///             ^ variable.parameter
///                ^^ storage.type.function.lambda
///                   ^ meta.function.anonymous punctuation.section.block.begin
///                                   ^ punctuation.section.block.end
///                                    ^ punctuation.terminator.statement - meta.function.anonymous

        try
///     ^^^ keyword.control.trycatch.try
        {

        }
        catch (InvalidOperationException ex)
///     ^^^^^ keyword.control.trycatch.catch
        {

        }
        finally
///     ^^^^^^^ keyword.control.trycatch.finally
        {
        }
        
        goto abc;
///     ^^^^ keyword.control.flow.goto
///          ^^^ constant.other.label
    abc:
/// ^^^ entity.name.label
///    ^ punctuation.separator
    }
}
///<- punctuation.section.block.end
