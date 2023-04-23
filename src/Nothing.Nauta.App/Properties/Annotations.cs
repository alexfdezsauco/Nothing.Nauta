// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Annotations.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// ReSharper disable UnusedType.Global
#pragma warning disable 1591
// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable IntroduceOptionalParameters.Global
// ReSharper disable MemberCanBeProtected.Global
// ReSharper disable InconsistentNaming

namespace Nothing.Nauta.App.Annotations
{

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  /// <summary>
  /// Indicates that the value of the marked element could be <c>null</c> sometimes,
  /// so checking for <c>null</c> is required before its usage.
  /// </summary>
  /// <example><code>
  /// [CanBeNull] object Test() => null;
  /// 
After:
    /* MIT License

Copyright (c) 2016 JetBrains http://www.jetbrains.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE. */

#nullable disable

    using System;

  /// <summary>
  /// Specifies the details of implicitly used symbol when it is marked
  /// with <see cref="MeansImplicitUseAttribute"/> or <see cref="UsedImplicitlyAttribute"/>.
  /// </summary>
  [Flags]
  public enum ImplicitUseKindFlags
  {
    Default = Access | Assign | InstantiatedWithFixedConstructorSignature,

    /// <summary>Only entity marked with attribute considered used.</summary>
    Access = 1,

    /// <summary>Indicates implicit assignment to a member.</summary>
    Assign = 2,

    /// <summary>
    /// Indicates implicit instantiation of a type with fixed constructor signature.
    /// That means any unused constructor parameters won't be reported as such.
    /// </summary>
    InstantiatedWithFixedConstructorSignature = 4,

    /// <summary>Indicates implicit instantiation of a type.</summary>
    InstantiatedNoFixedConstructorSignature = 8,
  }

  /// <summary>
  /// Indicates that the value of the marked element could be <c>null</c> sometimes,
  /// so checking for <c>null</c> is required before its usage.
  /// </summary>
  /// <example><code>
  /// [CanBeNull] object Test() => null;
  ///
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  /// <summary>
  /// Indicates that the value of the marked element could be <c>null</c> sometimes,
  /// so checking for <c>null</c> is required before its usage.
  /// </summary>
  /// <example><code>
  /// [CanBeNull] object Test() => null;
  /// 
After:
    /* MIT License

Copyright (c) 2016 JetBrains http://www.jetbrains.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE. */

#nullable disable

    using System;

  /// <summary>
  /// Specifies the details of implicitly used symbol when it is marked
  /// with <see cref="MeansImplicitUseAttribute"/> or <see cref="UsedImplicitlyAttribute"/>.
  /// </summary>
  [Flags]
  public enum ImplicitUseKindFlags
  {
    Default = Access | Assign | InstantiatedWithFixedConstructorSignature,

    /// <summary>Only entity marked with attribute considered used.</summary>
    Access = 1,

    /// <summary>Indicates implicit assignment to a member.</summary>
    Assign = 2,

    /// <summary>
    /// Indicates implicit instantiation of a type with fixed constructor signature.
    /// That means any unused constructor parameters won't be reported as such.
    /// </summary>
    InstantiatedWithFixedConstructorSignature = 4,

    /// <summary>Indicates implicit instantiation of a type.</summary>
    InstantiatedNoFixedConstructorSignature = 8,
  }

  /// <summary>
  /// Indicates that the value of the marked element could be <c>null</c> sometimes,
  /// so checking for <c>null</c> is required before its usage.
  /// </summary>
  /// <example><code>
  /// [CanBeNull] object Test() => null;
  ///
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  /// <summary>
  /// Indicates that the value of the marked element could be <c>null</c> sometimes,
  /// so checking for <c>null</c> is required before its usage.
  /// </summary>
  /// <example><code>
  /// [CanBeNull] object Test() => null;
  /// 
After:
    /* MIT License

Copyright (c) 2016 JetBrains http://www.jetbrains.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE. */

#nullable disable

    using System;

  /// <summary>
  /// Specifies the details of implicitly used symbol when it is marked
  /// with <see cref="MeansImplicitUseAttribute"/> or <see cref="UsedImplicitlyAttribute"/>.
  /// </summary>
  [Flags]
  public enum ImplicitUseKindFlags
  {
    Default = Access | Assign | InstantiatedWithFixedConstructorSignature,

    /// <summary>Only entity marked with attribute considered used.</summary>
    Access = 1,

    /// <summary>Indicates implicit assignment to a member.</summary>
    Assign = 2,

    /// <summary>
    /// Indicates implicit instantiation of a type with fixed constructor signature.
    /// That means any unused constructor parameters won't be reported as such.
    /// </summary>
    InstantiatedWithFixedConstructorSignature = 4,

    /// <summary>Indicates implicit instantiation of a type.</summary>
    InstantiatedNoFixedConstructorSignature = 8,
  }

  /// <summary>
  /// Indicates that the value of the marked element could be <c>null</c> sometimes,
  /// so checking for <c>null</c> is required before its usage.
  /// </summary>
  /// <example><code>
  /// [CanBeNull] object Test() => null;
  ///
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  /// <summary>
  /// Indicates that the value of the marked element could be <c>null</c> sometimes,
  /// so checking for <c>null</c> is required before its usage.
  /// </summary>
  /// <example><code>
  /// [CanBeNull] object Test() => null;
  /// 
After:
    /* MIT License

Copyright (c) 2016 JetBrains http://www.jetbrains.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE. */

#nullable disable

    using System;

  /// <summary>
  /// Specifies the details of implicitly used symbol when it is marked
  /// with <see cref="MeansImplicitUseAttribute"/> or <see cref="UsedImplicitlyAttribute"/>.
  /// </summary>
  [Flags]
  public enum ImplicitUseKindFlags
  {
    Default = Access | Assign | InstantiatedWithFixedConstructorSignature,

    /// <summary>Only entity marked with attribute considered used.</summary>
    Access = 1,

    /// <summary>Indicates implicit assignment to a member.</summary>
    Assign = 2,

    /// <summary>
    /// Indicates implicit instantiation of a type with fixed constructor signature.
    /// That means any unused constructor parameters won't be reported as such.
    /// </summary>
    InstantiatedWithFixedConstructorSignature = 4,

    /// <summary>Indicates implicit instantiation of a type.</summary>
    InstantiatedNoFixedConstructorSignature = 8,
  }

  /// <summary>
  /// Indicates that the value of the marked element could be <c>null</c> sometimes,
  /// so checking for <c>null</c> is required before its usage.
  /// </summary>
  /// <example><code>
  /// [CanBeNull] object Test() => null;
  ///
*/
    /* MIT License

Copyright (c) 2016 JetBrains http://www.jetbrains.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE. */

#nullable disable

    using System;

    /// <summary>
    /// Specifies the details of implicitly used symbol when it is marked
    /// with <see cref="MeansImplicitUseAttribute"/> or <see cref="UsedImplicitlyAttribute"/>.
    /// </summary>
    [Flags]
    public enum ImplicitUseKindFlags
    {
        Default = Access | Assign | InstantiatedWithFixedConstructorSignature,

        /// <summary>Only entity marked with attribute considered used.</summary>
        Access = 1,

        /// <summary>Indicates implicit assignment to a member.</summary>
        Assign = 2,

        /// <summary>
        /// Indicates implicit instantiation of a type with fixed constructor signature.
        /// That means any unused constructor parameters won't be reported as such.
        /// </summary>
        InstantiatedWithFixedConstructorSignature = 4,

        /// <summary>Indicates implicit instantiation of a type.</summary>
        InstantiatedNoFixedConstructorSignature = 8,
    }

    /// <summary>
    /// Indicates that the value of the marked element could be <c>null</c> sometimes,
    /// so checking for <c>null</c> is required before its usage.
    /// </summary>
    /// <example><code>
    /// [CanBeNull] object Test() => null;
    ///
    /// void UseTest() {
    ///   var p = Test();
    ///   var s = p.ToString(); // Warning: Possible 'System.NullReferenceException'
    /// }
    /// </code></example>
    [AttributeUsage(
      AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
      AttributeTargets.Delegate | AttributeTargets.Field | AttributeTargets.Event |
      AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.GenericParameter)]

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  public sealed class CanBeNullAttribute : Attribute { }

  /// <summary>
  /// Indicates that the value of the marked element can never be <c>null</c>.
  /// </summary>
  /// <example><code>
  /// [NotNull] object Foo() {
  ///   return null; // Warning: Possible 'null' assignment
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
    AttributeTargets.Delegate | AttributeTargets.Field | AttributeTargets.Event |
    AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.GenericParameter)]
  public sealed class NotNullAttribute : Attribute { }

  /// <summary>
  /// Can be applied to symbols of types derived from IEnumerable as well as to symbols of Task
  /// and Lazy classes to indicate that the value of a collection item, of the Task.Result property
  /// or of the Lazy.Value property can never be null.
  /// </summary>
  /// <example><code>
  /// public void Foo([ItemNotNull]List&lt;string&gt; books)
  /// {
  ///   foreach (var book in books) {
  ///     if (book != null) // Warning: Expression is always true
  ///      Console.WriteLine(book.ToUpper());
  ///   }
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
    AttributeTargets.Delegate | AttributeTargets.Field)]
  public sealed class ItemNotNullAttribute : Attribute { }

  /// <summary>
  /// Can be applied to symbols of types derived from IEnumerable as well as to symbols of Task
  /// and Lazy classes to indicate that the value of a collection item, of the Task.Result property
  /// or of the Lazy.Value property can be null.
  /// </summary>
  /// <example><code>
  /// public void Foo([ItemCanBeNull]List&lt;string&gt; books)
  /// {
  ///   foreach (var book in books)
  ///   {
  ///     // Warning: Possible 'System.NullReferenceException'
  ///     Console.WriteLine(book.ToUpper());
  ///   }
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
    AttributeTargets.Delegate | AttributeTargets.Field)]
  public sealed class ItemCanBeNullAttribute : Attribute { }

  /// <summary>
  /// Indicates that the marked method builds string by the format pattern and (optional) arguments.
  /// The parameter, which contains the format string, should be given in the constructor. The format string
  /// should be in <see cref="string.Format(IFormatProvider,string,object[])"/>-like form.
  /// </summary>
  /// <example><code>
  /// [StringFormatMethod("message")]
  /// void ShowError(string message, params object[] args) { /* do something */ }
  /// 
After:
  public sealed class CanBeNullAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the value of the marked element can never be <c>null</c>.
  /// </summary>
  /// <example><code>
  /// [NotNull] object Foo() {
  ///   return null; // Warning: Possible 'null' assignment
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
    AttributeTargets.Delegate | AttributeTargets.Field | AttributeTargets.Event |
    AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.GenericParameter)]
  public sealed class NotNullAttribute : Attribute
    {
    }

  /// <summary>
  /// Can be applied to symbols of types derived from IEnumerable as well as to symbols of Task
  /// and Lazy classes to indicate that the value of a collection item, of the Task.Result property
  /// or of the Lazy.Value property can never be null.
  /// </summary>
  /// <example><code>
  /// public void Foo([ItemNotNull]List&lt;string&gt; books)
  /// {
  ///   foreach (var book in books) {
  ///     if (book != null) // Warning: Expression is always true
  ///      Console.WriteLine(book.ToUpper());
  ///   }
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
    AttributeTargets.Delegate | AttributeTargets.Field)]
  public sealed class ItemNotNullAttribute : Attribute
    {
    }

  /// <summary>
  /// Can be applied to symbols of types derived from IEnumerable as well as to symbols of Task
  /// and Lazy classes to indicate that the value of a collection item, of the Task.Result property
  /// or of the Lazy.Value property can be null.
  /// </summary>
  /// <example><code>
  /// public void Foo([ItemCanBeNull]List&lt;string&gt; books)
  /// {
  ///   foreach (var book in books)
  ///   {
  ///     // Warning: Possible 'System.NullReferenceException'
  ///     Console.WriteLine(book.ToUpper());
  ///   }
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
    AttributeTargets.Delegate | AttributeTargets.Field)]
  public sealed class ItemCanBeNullAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked method builds string by the format pattern and (optional) arguments.
  /// The parameter, which contains the format string, should be given in the constructor. The format string
  /// should be in <see cref="string.Format(IFormatProvider,string,object[])"/>-like form.
  /// </summary>
  /// <example><code>
  /// [StringFormatMethod("message")]
  /// void ShowError(string message, params object[] args) { /* do something */ }
  ///
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  public sealed class CanBeNullAttribute : Attribute { }

  /// <summary>
  /// Indicates that the value of the marked element can never be <c>null</c>.
  /// </summary>
  /// <example><code>
  /// [NotNull] object Foo() {
  ///   return null; // Warning: Possible 'null' assignment
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
    AttributeTargets.Delegate | AttributeTargets.Field | AttributeTargets.Event |
    AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.GenericParameter)]
  public sealed class NotNullAttribute : Attribute { }

  /// <summary>
  /// Can be applied to symbols of types derived from IEnumerable as well as to symbols of Task
  /// and Lazy classes to indicate that the value of a collection item, of the Task.Result property
  /// or of the Lazy.Value property can never be null.
  /// </summary>
  /// <example><code>
  /// public void Foo([ItemNotNull]List&lt;string&gt; books)
  /// {
  ///   foreach (var book in books) {
  ///     if (book != null) // Warning: Expression is always true
  ///      Console.WriteLine(book.ToUpper());
  ///   }
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
    AttributeTargets.Delegate | AttributeTargets.Field)]
  public sealed class ItemNotNullAttribute : Attribute { }

  /// <summary>
  /// Can be applied to symbols of types derived from IEnumerable as well as to symbols of Task
  /// and Lazy classes to indicate that the value of a collection item, of the Task.Result property
  /// or of the Lazy.Value property can be null.
  /// </summary>
  /// <example><code>
  /// public void Foo([ItemCanBeNull]List&lt;string&gt; books)
  /// {
  ///   foreach (var book in books)
  ///   {
  ///     // Warning: Possible 'System.NullReferenceException'
  ///     Console.WriteLine(book.ToUpper());
  ///   }
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
    AttributeTargets.Delegate | AttributeTargets.Field)]
  public sealed class ItemCanBeNullAttribute : Attribute { }

  /// <summary>
  /// Indicates that the marked method builds string by the format pattern and (optional) arguments.
  /// The parameter, which contains the format string, should be given in the constructor. The format string
  /// should be in <see cref="string.Format(IFormatProvider,string,object[])"/>-like form.
  /// </summary>
  /// <example><code>
  /// [StringFormatMethod("message")]
  /// void ShowError(string message, params object[] args) { /* do something */ }
  /// 
After:
  public sealed class CanBeNullAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the value of the marked element can never be <c>null</c>.
  /// </summary>
  /// <example><code>
  /// [NotNull] object Foo() {
  ///   return null; // Warning: Possible 'null' assignment
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
    AttributeTargets.Delegate | AttributeTargets.Field | AttributeTargets.Event |
    AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.GenericParameter)]
  public sealed class NotNullAttribute : Attribute
    {
    }

  /// <summary>
  /// Can be applied to symbols of types derived from IEnumerable as well as to symbols of Task
  /// and Lazy classes to indicate that the value of a collection item, of the Task.Result property
  /// or of the Lazy.Value property can never be null.
  /// </summary>
  /// <example><code>
  /// public void Foo([ItemNotNull]List&lt;string&gt; books)
  /// {
  ///   foreach (var book in books) {
  ///     if (book != null) // Warning: Expression is always true
  ///      Console.WriteLine(book.ToUpper());
  ///   }
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
    AttributeTargets.Delegate | AttributeTargets.Field)]
  public sealed class ItemNotNullAttribute : Attribute
    {
    }

  /// <summary>
  /// Can be applied to symbols of types derived from IEnumerable as well as to symbols of Task
  /// and Lazy classes to indicate that the value of a collection item, of the Task.Result property
  /// or of the Lazy.Value property can be null.
  /// </summary>
  /// <example><code>
  /// public void Foo([ItemCanBeNull]List&lt;string&gt; books)
  /// {
  ///   foreach (var book in books)
  ///   {
  ///     // Warning: Possible 'System.NullReferenceException'
  ///     Console.WriteLine(book.ToUpper());
  ///   }
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
    AttributeTargets.Delegate | AttributeTargets.Field)]
  public sealed class ItemCanBeNullAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked method builds string by the format pattern and (optional) arguments.
  /// The parameter, which contains the format string, should be given in the constructor. The format string
  /// should be in <see cref="string.Format(IFormatProvider,string,object[])"/>-like form.
  /// </summary>
  /// <example><code>
  /// [StringFormatMethod("message")]
  /// void ShowError(string message, params object[] args) { /* do something */ }
  ///
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  public sealed class CanBeNullAttribute : Attribute { }

  /// <summary>
  /// Indicates that the value of the marked element can never be <c>null</c>.
  /// </summary>
  /// <example><code>
  /// [NotNull] object Foo() {
  ///   return null; // Warning: Possible 'null' assignment
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
    AttributeTargets.Delegate | AttributeTargets.Field | AttributeTargets.Event |
    AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.GenericParameter)]
  public sealed class NotNullAttribute : Attribute { }

  /// <summary>
  /// Can be applied to symbols of types derived from IEnumerable as well as to symbols of Task
  /// and Lazy classes to indicate that the value of a collection item, of the Task.Result property
  /// or of the Lazy.Value property can never be null.
  /// </summary>
  /// <example><code>
  /// public void Foo([ItemNotNull]List&lt;string&gt; books)
  /// {
  ///   foreach (var book in books) {
  ///     if (book != null) // Warning: Expression is always true
  ///      Console.WriteLine(book.ToUpper());
  ///   }
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
    AttributeTargets.Delegate | AttributeTargets.Field)]
  public sealed class ItemNotNullAttribute : Attribute { }

  /// <summary>
  /// Can be applied to symbols of types derived from IEnumerable as well as to symbols of Task
  /// and Lazy classes to indicate that the value of a collection item, of the Task.Result property
  /// or of the Lazy.Value property can be null.
  /// </summary>
  /// <example><code>
  /// public void Foo([ItemCanBeNull]List&lt;string&gt; books)
  /// {
  ///   foreach (var book in books)
  ///   {
  ///     // Warning: Possible 'System.NullReferenceException'
  ///     Console.WriteLine(book.ToUpper());
  ///   }
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
    AttributeTargets.Delegate | AttributeTargets.Field)]
  public sealed class ItemCanBeNullAttribute : Attribute { }

  /// <summary>
  /// Indicates that the marked method builds string by the format pattern and (optional) arguments.
  /// The parameter, which contains the format string, should be given in the constructor. The format string
  /// should be in <see cref="string.Format(IFormatProvider,string,object[])"/>-like form.
  /// </summary>
  /// <example><code>
  /// [StringFormatMethod("message")]
  /// void ShowError(string message, params object[] args) { /* do something */ }
  /// 
After:
  public sealed class CanBeNullAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the value of the marked element can never be <c>null</c>.
  /// </summary>
  /// <example><code>
  /// [NotNull] object Foo() {
  ///   return null; // Warning: Possible 'null' assignment
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
    AttributeTargets.Delegate | AttributeTargets.Field | AttributeTargets.Event |
    AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.GenericParameter)]
  public sealed class NotNullAttribute : Attribute
    {
    }

  /// <summary>
  /// Can be applied to symbols of types derived from IEnumerable as well as to symbols of Task
  /// and Lazy classes to indicate that the value of a collection item, of the Task.Result property
  /// or of the Lazy.Value property can never be null.
  /// </summary>
  /// <example><code>
  /// public void Foo([ItemNotNull]List&lt;string&gt; books)
  /// {
  ///   foreach (var book in books) {
  ///     if (book != null) // Warning: Expression is always true
  ///      Console.WriteLine(book.ToUpper());
  ///   }
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
    AttributeTargets.Delegate | AttributeTargets.Field)]
  public sealed class ItemNotNullAttribute : Attribute
    {
    }

  /// <summary>
  /// Can be applied to symbols of types derived from IEnumerable as well as to symbols of Task
  /// and Lazy classes to indicate that the value of a collection item, of the Task.Result property
  /// or of the Lazy.Value property can be null.
  /// </summary>
  /// <example><code>
  /// public void Foo([ItemCanBeNull]List&lt;string&gt; books)
  /// {
  ///   foreach (var book in books)
  ///   {
  ///     // Warning: Possible 'System.NullReferenceException'
  ///     Console.WriteLine(book.ToUpper());
  ///   }
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
    AttributeTargets.Delegate | AttributeTargets.Field)]
  public sealed class ItemCanBeNullAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked method builds string by the format pattern and (optional) arguments.
  /// The parameter, which contains the format string, should be given in the constructor. The format string
  /// should be in <see cref="string.Format(IFormatProvider,string,object[])"/>-like form.
  /// </summary>
  /// <example><code>
  /// [StringFormatMethod("message")]
  /// void ShowError(string message, params object[] args) { /* do something */ }
  ///
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  public sealed class CanBeNullAttribute : Attribute { }

  /// <summary>
  /// Indicates that the value of the marked element can never be <c>null</c>.
  /// </summary>
  /// <example><code>
  /// [NotNull] object Foo() {
  ///   return null; // Warning: Possible 'null' assignment
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
    AttributeTargets.Delegate | AttributeTargets.Field | AttributeTargets.Event |
    AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.GenericParameter)]
  public sealed class NotNullAttribute : Attribute { }

  /// <summary>
  /// Can be applied to symbols of types derived from IEnumerable as well as to symbols of Task
  /// and Lazy classes to indicate that the value of a collection item, of the Task.Result property
  /// or of the Lazy.Value property can never be null.
  /// </summary>
  /// <example><code>
  /// public void Foo([ItemNotNull]List&lt;string&gt; books)
  /// {
  ///   foreach (var book in books) {
  ///     if (book != null) // Warning: Expression is always true
  ///      Console.WriteLine(book.ToUpper());
  ///   }
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
    AttributeTargets.Delegate | AttributeTargets.Field)]
  public sealed class ItemNotNullAttribute : Attribute { }

  /// <summary>
  /// Can be applied to symbols of types derived from IEnumerable as well as to symbols of Task
  /// and Lazy classes to indicate that the value of a collection item, of the Task.Result property
  /// or of the Lazy.Value property can be null.
  /// </summary>
  /// <example><code>
  /// public void Foo([ItemCanBeNull]List&lt;string&gt; books)
  /// {
  ///   foreach (var book in books)
  ///   {
  ///     // Warning: Possible 'System.NullReferenceException'
  ///     Console.WriteLine(book.ToUpper());
  ///   }
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
    AttributeTargets.Delegate | AttributeTargets.Field)]
  public sealed class ItemCanBeNullAttribute : Attribute { }

  /// <summary>
  /// Indicates that the marked method builds string by the format pattern and (optional) arguments.
  /// The parameter, which contains the format string, should be given in the constructor. The format string
  /// should be in <see cref="string.Format(IFormatProvider,string,object[])"/>-like form.
  /// </summary>
  /// <example><code>
  /// [StringFormatMethod("message")]
  /// void ShowError(string message, params object[] args) { /* do something */ }
  /// 
After:
  public sealed class CanBeNullAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the value of the marked element can never be <c>null</c>.
  /// </summary>
  /// <example><code>
  /// [NotNull] object Foo() {
  ///   return null; // Warning: Possible 'null' assignment
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
    AttributeTargets.Delegate | AttributeTargets.Field | AttributeTargets.Event |
    AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.GenericParameter)]
  public sealed class NotNullAttribute : Attribute
    {
    }

  /// <summary>
  /// Can be applied to symbols of types derived from IEnumerable as well as to symbols of Task
  /// and Lazy classes to indicate that the value of a collection item, of the Task.Result property
  /// or of the Lazy.Value property can never be null.
  /// </summary>
  /// <example><code>
  /// public void Foo([ItemNotNull]List&lt;string&gt; books)
  /// {
  ///   foreach (var book in books) {
  ///     if (book != null) // Warning: Expression is always true
  ///      Console.WriteLine(book.ToUpper());
  ///   }
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
    AttributeTargets.Delegate | AttributeTargets.Field)]
  public sealed class ItemNotNullAttribute : Attribute
    {
    }

  /// <summary>
  /// Can be applied to symbols of types derived from IEnumerable as well as to symbols of Task
  /// and Lazy classes to indicate that the value of a collection item, of the Task.Result property
  /// or of the Lazy.Value property can be null.
  /// </summary>
  /// <example><code>
  /// public void Foo([ItemCanBeNull]List&lt;string&gt; books)
  /// {
  ///   foreach (var book in books)
  ///   {
  ///     // Warning: Possible 'System.NullReferenceException'
  ///     Console.WriteLine(book.ToUpper());
  ///   }
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
    AttributeTargets.Delegate | AttributeTargets.Field)]
  public sealed class ItemCanBeNullAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked method builds string by the format pattern and (optional) arguments.
  /// The parameter, which contains the format string, should be given in the constructor. The format string
  /// should be in <see cref="string.Format(IFormatProvider,string,object[])"/>-like form.
  /// </summary>
  /// <example><code>
  /// [StringFormatMethod("message")]
  /// void ShowError(string message, params object[] args) { /* do something */ }
  ///
*/
    public sealed class CanBeNullAttribute : Attribute
    {
    }

    /// <summary>
    /// Indicates that the value of the marked element can never be <c>null</c>.
    /// </summary>
    /// <example><code>
    /// [NotNull] object Foo() {
    ///   return null; // Warning: Possible 'null' assignment
    /// }
    /// </code></example>
    [AttributeUsage(
      AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
      AttributeTargets.Delegate | AttributeTargets.Field | AttributeTargets.Event |
      AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.GenericParameter)]
    public sealed class NotNullAttribute : Attribute
    {
    }

    /// <summary>
    /// Can be applied to symbols of types derived from IEnumerable as well as to symbols of Task
    /// and Lazy classes to indicate that the value of a collection item, of the Task.Result property
    /// or of the Lazy.Value property can never be null.
    /// </summary>
    /// <example><code>
    /// public void Foo([ItemNotNull]List&lt;string&gt; books)
    /// {
    ///   foreach (var book in books) {
    ///     if (book != null) // Warning: Expression is always true
    ///      Console.WriteLine(book.ToUpper());
    ///   }
    /// }
    /// </code></example>
    [AttributeUsage(
      AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
      AttributeTargets.Delegate | AttributeTargets.Field)]
    public sealed class ItemNotNullAttribute : Attribute
    {
    }

    /// <summary>
    /// Can be applied to symbols of types derived from IEnumerable as well as to symbols of Task
    /// and Lazy classes to indicate that the value of a collection item, of the Task.Result property
    /// or of the Lazy.Value property can be null.
    /// </summary>
    /// <example><code>
    /// public void Foo([ItemCanBeNull]List&lt;string&gt; books)
    /// {
    ///   foreach (var book in books)
    ///   {
    ///     // Warning: Possible 'System.NullReferenceException'
    ///     Console.WriteLine(book.ToUpper());
    ///   }
    /// }
    /// </code></example>
    [AttributeUsage(
      AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
      AttributeTargets.Delegate | AttributeTargets.Field)]
    public sealed class ItemCanBeNullAttribute : Attribute
    {
    }

    /// <summary>
    /// Indicates that the marked method builds string by the format pattern and (optional) arguments.
    /// The parameter, which contains the format string, should be given in the constructor. The format string
    /// should be in <see cref="string.Format(IFormatProvider,string,object[])"/>-like form.
    /// </summary>
    /// <example><code>
    /// [StringFormatMethod("message")]
    /// void ShowError(string message, params object[] args) { /* do something */ }
    ///
    /// void Foo() {
    ///   ShowError("Failed: {0}"); // Warning: Non-existing argument in format string
    /// }
    /// </code></example>
    [AttributeUsage(
      AttributeTargets.Constructor | AttributeTargets.Method |
      AttributeTargets.Property | AttributeTargets.Delegate)]
  
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    /// Specifies which parameter of an annotated method should be treated as the format string
After:
    /// Specifies which parameter of an annotated method should be treated as the format string.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    /// Specifies which parameter of an annotated method should be treated as the format string
After:
    /// Specifies which parameter of an annotated method should be treated as the format string.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    /// Specifies which parameter of an annotated method should be treated as the format string
After:
    /// Specifies which parameter of an annotated method should be treated as the format string.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    /// Specifies which parameter of an annotated method should be treated as the format string
After:
    /// Specifies which parameter of an annotated method should be treated as the format string.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      FormatParameterName = formatParameterName;
After:
      this.FormatParameterName = formatParameterName;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      FormatParameterName = formatParameterName;
After:
      this.FormatParameterName = formatParameterName;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      FormatParameterName = formatParameterName;
After:
      this.FormatParameterName = formatParameterName;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      FormatParameterName = formatParameterName;
After:
      this.FormatParameterName = formatParameterName;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    [NotNull] public string FormatParameterName { get; }
After:
    [NotNull]
        public string FormatParameterName { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    [NotNull] public string FormatParameterName { get; }
After:
    [NotNull]
        public string FormatParameterName { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    [NotNull] public string FormatParameterName { get; }
After:
    [NotNull]
        public string FormatParameterName { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    [NotNull] public string FormatParameterName { get; }
After:
    [NotNull]
        public string FormatParameterName { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  /// in the order in which they appear
  /// </summary>
  /// <example><code>
  /// void LogInfo([StructuredMessageTemplate]string message, params object[] args) { /* do something */ }
  /// 
After:
  /// in the order in which they appear.
  /// </summary>
  /// <example><code>
  /// void LogInfo([StructuredMessageTemplate]string message, params object[] args) { /* do something */ }
  ///
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  /// in the order in which they appear
  /// </summary>
  /// <example><code>
  /// void LogInfo([StructuredMessageTemplate]string message, params object[] args) { /* do something */ }
  /// 
After:
  /// in the order in which they appear.
  /// </summary>
  /// <example><code>
  /// void LogInfo([StructuredMessageTemplate]string message, params object[] args) { /* do something */ }
  ///
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  /// in the order in which they appear
  /// </summary>
  /// <example><code>
  /// void LogInfo([StructuredMessageTemplate]string message, params object[] args) { /* do something */ }
  /// 
After:
  /// in the order in which they appear.
  /// </summary>
  /// <example><code>
  /// void LogInfo([StructuredMessageTemplate]string message, params object[] args) { /* do something */ }
  ///
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  /// in the order in which they appear
  /// </summary>
  /// <example><code>
  /// void LogInfo([StructuredMessageTemplate]string message, params object[] args) { /* do something */ }
  /// 
After:
  /// in the order in which they appear.
  /// </summary>
  /// <example><code>
  /// void LogInfo([StructuredMessageTemplate]string message, params object[] args) { /* do something */ }
  ///
*/
  public sealed class StringFormatMethodAttribute : Attribute
    {
        /// <param name="formatParameterName">
        /// Specifies which parameter of an annotated method should be treated as the format string.
        /// </param>
        public StringFormatMethodAttribute([NotNull] string formatParameterName)
        {
            this.FormatParameterName = formatParameterName;
        }

        [NotNull]
        public string FormatParameterName { get; }
    }

    /// <summary>
    /// Indicates that the marked parameter is a message template where placeholders are to be replaced by the following arguments
    /// in the order in which they appear.
    /// </summary>
    /// <example><code>
    /// void LogInfo([StructuredMessageTemplate]string message, params object[] args) { /* do something */ }
    ///
    /// void Foo() {
    ///   LogInfo("User created: {username}"); // Warning: Non-existing argument in format string
    /// }
    /// </code></example>
    [AttributeUsage(AttributeTargets.Parameter)]

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  public sealed class StructuredMessageTemplateAttribute : Attribute {}
After:
  public sealed class StructuredMessageTemplateAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  public sealed class StructuredMessageTemplateAttribute : Attribute {}
After:
  public sealed class StructuredMessageTemplateAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  public sealed class StructuredMessageTemplateAttribute : Attribute {}
After:
  public sealed class StructuredMessageTemplateAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  public sealed class StructuredMessageTemplateAttribute : Attribute {}
After:
  public sealed class StructuredMessageTemplateAttribute : Attribute
    {
    }
*/
    public sealed class StructuredMessageTemplateAttribute : Attribute
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      Name = name;
After:
      this.Name = name;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      Name = name;
After:
      this.Name = name;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      Name = name;
After:
      this.Name = name;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      Name = name;
After:
      this.Name = name;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    [NotNull] public string Name { get; }
After:
    [NotNull]
        public string Name { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    [NotNull] public string Name { get; }
After:
    [NotNull]
        public string Name { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    [NotNull] public string Name { get; }
After:
    [NotNull]
        public string Name { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    [NotNull] public string Name { get; }
After:
    [NotNull]
        public string Name { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    public object From { get; }
    public object To { get; }

    public ValueRangeAttribute(long from, long to)
After:
    public ValueRangeAttribute(long from, long to)
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    public object From { get; }
    public object To { get; }

    public ValueRangeAttribute(long from, long to)
After:
    public ValueRangeAttribute(long from, long to)
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    public object From { get; }
    public object To { get; }

    public ValueRangeAttribute(long from, long to)
After:
    public ValueRangeAttribute(long from, long to)
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    public object From { get; }
    public object To { get; }

    public ValueRangeAttribute(long from, long to)
After:
    public ValueRangeAttribute(long from, long to)
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      From = from;
      To = to;
After:
      this.From = from;
      this.To = to;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      From = from;
      To = to;
After:
      this.From = from;
      this.To = to;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      From = from;
      To = to;
After:
      this.From = from;
      this.To = to;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      From = from;
      To = to;
After:
      this.From = from;
      this.To = to;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    public ValueRangeAttribute(ulong from, ulong to)
    {
      From = from;
      To = to;
    }

    public ValueRangeAttribute(long value)
    {
      From = To = value;
    }
After:
    public object From { get; }

    public object To { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    public ValueRangeAttribute(ulong from, ulong to)
    {
      From = from;
      To = to;
    }

    public ValueRangeAttribute(long value)
    {
      From = To = value;
    }
After:
    public object From { get; }

    public object To { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    public ValueRangeAttribute(ulong from, ulong to)
    {
      From = from;
      To = to;
    }

    public ValueRangeAttribute(long value)
    {
      From = To = value;
    }
After:
    public object From { get; }

    public object To { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    public ValueRangeAttribute(ulong from, ulong to)
    {
      From = from;
      To = to;
    }

    public ValueRangeAttribute(long value)
    {
      From = To = value;
    }
After:
    public object From { get; }

    public object To { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    public ValueRangeAttribute(ulong value)
After:
    public ValueRangeAttribute(ulong from, ulong to)
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    public ValueRangeAttribute(ulong value)
After:
    public ValueRangeAttribute(ulong from, ulong to)
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    public ValueRangeAttribute(ulong value)
After:
    public ValueRangeAttribute(ulong from, ulong to)
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    public ValueRangeAttribute(ulong value)
After:
    public ValueRangeAttribute(ulong from, ulong to)
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      From = To = value;
After:
      this.From = from;
      this.To = to;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      From = To = value;
After:
      this.From = from;
      this.To = to;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      From = To = value;
After:
      this.From = from;
      this.To = to;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      From = To = value;
After:
      this.From = from;
      this.To = to;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  }

  /// <summary>
  /// Indicates that the integral value never falls below zero.
  /// </summary>
  /// <example><code>
  /// void Foo([NonNegativeValue] int value) {
  ///   if (value == -1) { // Warning: Expression is always 'false'
  ///     ...
  ///   }
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property |
    AttributeTargets.Method | AttributeTargets.Delegate)]
  public sealed class NonNegativeValueAttribute : Attribute { }

  /// <summary>
  /// Indicates that the function argument should be a string literal and match
  /// one of the parameters of the caller function. This annotation is used for paramerers
  /// like 'string paramName' parameter of the <see cref="System.ArgumentNullException"/> constuctor.
  /// </summary>
  /// <example><code>
  /// void Foo(string param) {
  ///   if (param == null)
  ///     throw new ArgumentNullException("par"); // Warning: Cannot resolve symbol
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class InvokerParameterNameAttribute : Attribute { }

  /// <summary>
  /// Indicates that the method is contained in a type that implements
  /// <c>System.ComponentModel.INotifyPropertyChanged</c> interface and this method
  /// is used to notify that some property value changed.
  /// </summary>
  /// <remarks>
  /// The method should be non-static and conform to one of the supported signatures:
  /// <list>
  /// <item><c>NotifyChanged(string)</c></item>
  /// <item><c>NotifyChanged(params string[])</c></item>
  /// <item><c>NotifyChanged{T}(Expression{Func{T}})</c></item>
  /// <item><c>NotifyChanged{T,U}(Expression{Func{T,U}})</c></item>
  /// <item><c>SetProperty{T}(ref T, T, string)</c></item>
  /// </list>
  /// </remarks>
  /// <example><code>
  /// public class Foo : INotifyPropertyChanged {
  ///   public event PropertyChangedEventHandler PropertyChanged;
  /// 
  ///   [NotifyPropertyChangedInvocator]
  ///   protected virtual void NotifyChanged(string propertyName) { ... }
  ///
  ///   string _name;
  /// 
After:
    public ValueRangeAttribute(long value)
    {
      this.From = this.To = value;
    }

    public ValueRangeAttribute(ulong value)
    {
      this.From = this.To = value;
    }
  }

  /// <summary>
  /// Indicates that the integral value never falls below zero.
  /// </summary>
  /// <example><code>
  /// void Foo([NonNegativeValue] int value) {
  ///   if (value == -1) { // Warning: Expression is always 'false'
  ///     ...
  ///   }
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property |
    AttributeTargets.Method | AttributeTargets.Delegate)]
  public sealed class NonNegativeValueAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the function argument should be a string literal and match
  /// one of the parameters of the caller function. This annotation is used for paramerers
  /// like 'string paramName' parameter of the <see cref="System.ArgumentNullException"/> constuctor.
  /// </summary>
  /// <example><code>
  /// void Foo(string param) {
  ///   if (param == null)
  ///     throw new ArgumentNullException("par"); // Warning: Cannot resolve symbol
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class InvokerParameterNameAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the method is contained in a type that implements
  /// <c>System.ComponentModel.INotifyPropertyChanged</c> interface and this method
  /// is used to notify that some property value changed.
  /// </summary>
  /// <remarks>
  /// The method should be non-static and conform to one of the supported signatures:
  /// <list>
  /// <item><c>NotifyChanged(string)</c></item>
  /// <item><c>NotifyChanged(params string[])</c></item>
  /// <item><c>NotifyChanged{T}(Expression{Func{T}})</c></item>
  /// <item><c>NotifyChanged{T,U}(Expression{Func{T,U}})</c></item>
  /// <item><c>SetProperty{T}(ref T, T, string)</c></item>
  /// </list>
  /// </remarks>
  /// <example><code>
  /// public class Foo : INotifyPropertyChanged {
  ///   public event PropertyChangedEventHandler PropertyChanged;
  ///
  ///   [NotifyPropertyChangedInvocator]
  ///   protected virtual void NotifyChanged(string propertyName) { ... }
  ///
  ///   string _name;
  ///
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  }

  /// <summary>
  /// Indicates that the integral value never falls below zero.
  /// </summary>
  /// <example><code>
  /// void Foo([NonNegativeValue] int value) {
  ///   if (value == -1) { // Warning: Expression is always 'false'
  ///     ...
  ///   }
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property |
    AttributeTargets.Method | AttributeTargets.Delegate)]
  public sealed class NonNegativeValueAttribute : Attribute { }

  /// <summary>
  /// Indicates that the function argument should be a string literal and match
  /// one of the parameters of the caller function. This annotation is used for paramerers
  /// like 'string paramName' parameter of the <see cref="System.ArgumentNullException"/> constuctor.
  /// </summary>
  /// <example><code>
  /// void Foo(string param) {
  ///   if (param == null)
  ///     throw new ArgumentNullException("par"); // Warning: Cannot resolve symbol
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class InvokerParameterNameAttribute : Attribute { }

  /// <summary>
  /// Indicates that the method is contained in a type that implements
  /// <c>System.ComponentModel.INotifyPropertyChanged</c> interface and this method
  /// is used to notify that some property value changed.
  /// </summary>
  /// <remarks>
  /// The method should be non-static and conform to one of the supported signatures:
  /// <list>
  /// <item><c>NotifyChanged(string)</c></item>
  /// <item><c>NotifyChanged(params string[])</c></item>
  /// <item><c>NotifyChanged{T}(Expression{Func{T}})</c></item>
  /// <item><c>NotifyChanged{T,U}(Expression{Func{T,U}})</c></item>
  /// <item><c>SetProperty{T}(ref T, T, string)</c></item>
  /// </list>
  /// </remarks>
  /// <example><code>
  /// public class Foo : INotifyPropertyChanged {
  ///   public event PropertyChangedEventHandler PropertyChanged;
  /// 
  ///   [NotifyPropertyChangedInvocator]
  ///   protected virtual void NotifyChanged(string propertyName) { ... }
  ///
  ///   string _name;
  /// 
After:
    public ValueRangeAttribute(long value)
    {
      this.From = this.To = value;
    }

    public ValueRangeAttribute(ulong value)
    {
      this.From = this.To = value;
    }
  }

  /// <summary>
  /// Indicates that the integral value never falls below zero.
  /// </summary>
  /// <example><code>
  /// void Foo([NonNegativeValue] int value) {
  ///   if (value == -1) { // Warning: Expression is always 'false'
  ///     ...
  ///   }
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property |
    AttributeTargets.Method | AttributeTargets.Delegate)]
  public sealed class NonNegativeValueAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the function argument should be a string literal and match
  /// one of the parameters of the caller function. This annotation is used for paramerers
  /// like 'string paramName' parameter of the <see cref="System.ArgumentNullException"/> constuctor.
  /// </summary>
  /// <example><code>
  /// void Foo(string param) {
  ///   if (param == null)
  ///     throw new ArgumentNullException("par"); // Warning: Cannot resolve symbol
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class InvokerParameterNameAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the method is contained in a type that implements
  /// <c>System.ComponentModel.INotifyPropertyChanged</c> interface and this method
  /// is used to notify that some property value changed.
  /// </summary>
  /// <remarks>
  /// The method should be non-static and conform to one of the supported signatures:
  /// <list>
  /// <item><c>NotifyChanged(string)</c></item>
  /// <item><c>NotifyChanged(params string[])</c></item>
  /// <item><c>NotifyChanged{T}(Expression{Func{T}})</c></item>
  /// <item><c>NotifyChanged{T,U}(Expression{Func{T,U}})</c></item>
  /// <item><c>SetProperty{T}(ref T, T, string)</c></item>
  /// </list>
  /// </remarks>
  /// <example><code>
  /// public class Foo : INotifyPropertyChanged {
  ///   public event PropertyChangedEventHandler PropertyChanged;
  ///
  ///   [NotifyPropertyChangedInvocator]
  ///   protected virtual void NotifyChanged(string propertyName) { ... }
  ///
  ///   string _name;
  ///
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  }

  /// <summary>
  /// Indicates that the integral value never falls below zero.
  /// </summary>
  /// <example><code>
  /// void Foo([NonNegativeValue] int value) {
  ///   if (value == -1) { // Warning: Expression is always 'false'
  ///     ...
  ///   }
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property |
    AttributeTargets.Method | AttributeTargets.Delegate)]
  public sealed class NonNegativeValueAttribute : Attribute { }

  /// <summary>
  /// Indicates that the function argument should be a string literal and match
  /// one of the parameters of the caller function. This annotation is used for paramerers
  /// like 'string paramName' parameter of the <see cref="System.ArgumentNullException"/> constuctor.
  /// </summary>
  /// <example><code>
  /// void Foo(string param) {
  ///   if (param == null)
  ///     throw new ArgumentNullException("par"); // Warning: Cannot resolve symbol
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class InvokerParameterNameAttribute : Attribute { }

  /// <summary>
  /// Indicates that the method is contained in a type that implements
  /// <c>System.ComponentModel.INotifyPropertyChanged</c> interface and this method
  /// is used to notify that some property value changed.
  /// </summary>
  /// <remarks>
  /// The method should be non-static and conform to one of the supported signatures:
  /// <list>
  /// <item><c>NotifyChanged(string)</c></item>
  /// <item><c>NotifyChanged(params string[])</c></item>
  /// <item><c>NotifyChanged{T}(Expression{Func{T}})</c></item>
  /// <item><c>NotifyChanged{T,U}(Expression{Func{T,U}})</c></item>
  /// <item><c>SetProperty{T}(ref T, T, string)</c></item>
  /// </list>
  /// </remarks>
  /// <example><code>
  /// public class Foo : INotifyPropertyChanged {
  ///   public event PropertyChangedEventHandler PropertyChanged;
  /// 
  ///   [NotifyPropertyChangedInvocator]
  ///   protected virtual void NotifyChanged(string propertyName) { ... }
  ///
  ///   string _name;
  /// 
After:
    public ValueRangeAttribute(long value)
    {
      this.From = this.To = value;
    }

    public ValueRangeAttribute(ulong value)
    {
      this.From = this.To = value;
    }
  }

  /// <summary>
  /// Indicates that the integral value never falls below zero.
  /// </summary>
  /// <example><code>
  /// void Foo([NonNegativeValue] int value) {
  ///   if (value == -1) { // Warning: Expression is always 'false'
  ///     ...
  ///   }
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property |
    AttributeTargets.Method | AttributeTargets.Delegate)]
  public sealed class NonNegativeValueAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the function argument should be a string literal and match
  /// one of the parameters of the caller function. This annotation is used for paramerers
  /// like 'string paramName' parameter of the <see cref="System.ArgumentNullException"/> constuctor.
  /// </summary>
  /// <example><code>
  /// void Foo(string param) {
  ///   if (param == null)
  ///     throw new ArgumentNullException("par"); // Warning: Cannot resolve symbol
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class InvokerParameterNameAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the method is contained in a type that implements
  /// <c>System.ComponentModel.INotifyPropertyChanged</c> interface and this method
  /// is used to notify that some property value changed.
  /// </summary>
  /// <remarks>
  /// The method should be non-static and conform to one of the supported signatures:
  /// <list>
  /// <item><c>NotifyChanged(string)</c></item>
  /// <item><c>NotifyChanged(params string[])</c></item>
  /// <item><c>NotifyChanged{T}(Expression{Func{T}})</c></item>
  /// <item><c>NotifyChanged{T,U}(Expression{Func{T,U}})</c></item>
  /// <item><c>SetProperty{T}(ref T, T, string)</c></item>
  /// </list>
  /// </remarks>
  /// <example><code>
  /// public class Foo : INotifyPropertyChanged {
  ///   public event PropertyChangedEventHandler PropertyChanged;
  ///
  ///   [NotifyPropertyChangedInvocator]
  ///   protected virtual void NotifyChanged(string propertyName) { ... }
  ///
  ///   string _name;
  ///
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  }

  /// <summary>
  /// Indicates that the integral value never falls below zero.
  /// </summary>
  /// <example><code>
  /// void Foo([NonNegativeValue] int value) {
  ///   if (value == -1) { // Warning: Expression is always 'false'
  ///     ...
  ///   }
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property |
    AttributeTargets.Method | AttributeTargets.Delegate)]
  public sealed class NonNegativeValueAttribute : Attribute { }

  /// <summary>
  /// Indicates that the function argument should be a string literal and match
  /// one of the parameters of the caller function. This annotation is used for paramerers
  /// like 'string paramName' parameter of the <see cref="System.ArgumentNullException"/> constuctor.
  /// </summary>
  /// <example><code>
  /// void Foo(string param) {
  ///   if (param == null)
  ///     throw new ArgumentNullException("par"); // Warning: Cannot resolve symbol
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class InvokerParameterNameAttribute : Attribute { }

  /// <summary>
  /// Indicates that the method is contained in a type that implements
  /// <c>System.ComponentModel.INotifyPropertyChanged</c> interface and this method
  /// is used to notify that some property value changed.
  /// </summary>
  /// <remarks>
  /// The method should be non-static and conform to one of the supported signatures:
  /// <list>
  /// <item><c>NotifyChanged(string)</c></item>
  /// <item><c>NotifyChanged(params string[])</c></item>
  /// <item><c>NotifyChanged{T}(Expression{Func{T}})</c></item>
  /// <item><c>NotifyChanged{T,U}(Expression{Func{T,U}})</c></item>
  /// <item><c>SetProperty{T}(ref T, T, string)</c></item>
  /// </list>
  /// </remarks>
  /// <example><code>
  /// public class Foo : INotifyPropertyChanged {
  ///   public event PropertyChangedEventHandler PropertyChanged;
  /// 
  ///   [NotifyPropertyChangedInvocator]
  ///   protected virtual void NotifyChanged(string propertyName) { ... }
  ///
  ///   string _name;
  /// 
After:
    public ValueRangeAttribute(long value)
    {
      this.From = this.To = value;
    }

    public ValueRangeAttribute(ulong value)
    {
      this.From = this.To = value;
    }
  }

  /// <summary>
  /// Indicates that the integral value never falls below zero.
  /// </summary>
  /// <example><code>
  /// void Foo([NonNegativeValue] int value) {
  ///   if (value == -1) { // Warning: Expression is always 'false'
  ///     ...
  ///   }
  /// }
  /// </code></example>
  [AttributeUsage(
    AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property |
    AttributeTargets.Method | AttributeTargets.Delegate)]
  public sealed class NonNegativeValueAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the function argument should be a string literal and match
  /// one of the parameters of the caller function. This annotation is used for paramerers
  /// like 'string paramName' parameter of the <see cref="System.ArgumentNullException"/> constuctor.
  /// </summary>
  /// <example><code>
  /// void Foo(string param) {
  ///   if (param == null)
  ///     throw new ArgumentNullException("par"); // Warning: Cannot resolve symbol
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class InvokerParameterNameAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the method is contained in a type that implements
  /// <c>System.ComponentModel.INotifyPropertyChanged</c> interface and this method
  /// is used to notify that some property value changed.
  /// </summary>
  /// <remarks>
  /// The method should be non-static and conform to one of the supported signatures:
  /// <list>
  /// <item><c>NotifyChanged(string)</c></item>
  /// <item><c>NotifyChanged(params string[])</c></item>
  /// <item><c>NotifyChanged{T}(Expression{Func{T}})</c></item>
  /// <item><c>NotifyChanged{T,U}(Expression{Func{T,U}})</c></item>
  /// <item><c>SetProperty{T}(ref T, T, string)</c></item>
  /// </list>
  /// </remarks>
  /// <example><code>
  /// public class Foo : INotifyPropertyChanged {
  ///   public event PropertyChangedEventHandler PropertyChanged;
  ///
  ///   [NotifyPropertyChangedInvocator]
  ///   protected virtual void NotifyChanged(string propertyName) { ... }
  ///
  ///   string _name;
  ///
*/

    {
    }

    /// <summary>
    /// Use this annotation to specify a type that contains static or const fields
    /// with values for the annotated property/field/parameter.
    /// The specified type will be used to improve completion suggestions.
    /// </summary>
    /// <example><code>
    /// namespace TestNamespace
    /// {
    ///   public class Constants
    ///   {
    ///     public static int INT_CONST = 1;
    ///     public const string STRING_CONST = "1";
    ///   }
    ///
    ///   public class Class1
    ///   {
    ///     [ValueProvider("TestNamespace.Constants")] public int myField;
    ///     public void Foo([ValueProvider("TestNamespace.Constants")] string str) { }
    ///
    ///     public void Test()
    ///     {
    ///       Foo(/*try completion here*/);//
    ///       myField = /*try completion here*/
    ///     }
    ///   }
    /// }
    /// </code></example>
    [AttributeUsage(
      AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.Field,
      AllowMultiple = true)]
    public sealed class ValueProviderAttribute : Attribute
    {
        public ValueProviderAttribute([NotNull] string name)
        {
            this.Name = name;
        }

        [NotNull]
        public string Name { get; }
    }

    /// <summary>
    /// Indicates that the integral value falls into the specified interval.
    /// It's allowed to specify multiple non-intersecting intervals.
    /// Values of interval boundaries are inclusive.
    /// </summary>
    /// <example><code>
    /// void Foo([ValueRange(0, 100)] int value) {
    ///   if (value == -1) { // Warning: Expression is always 'false'
    ///     ...
    ///   }
    /// }
    /// </code></example>
    [AttributeUsage(
      AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property |
      AttributeTargets.Method | AttributeTargets.Delegate,
      AllowMultiple = true)]
    public sealed class ValueRangeAttribute : Attribute
    {
        public ValueRangeAttribute(long from, long to)
        {
            this.From = from;
            this.To = to;
        }

        public object From { get; }

        public object To { get; }

        public ValueRangeAttribute(ulong from, ulong to)
        {
            this.From = from;
            this.To = to;
        }

        public ValueRangeAttribute(long value)
        {
            this.From = this.To = value;
        }

        public ValueRangeAttribute(ulong value)
        {
            this.From = this.To = value;
        }
    }

    /// <summary>
    /// Indicates that the integral value never falls below zero.
    /// </summary>
    /// <example><code>
    /// void Foo([NonNegativeValue] int value) {
    ///   if (value == -1) { // Warning: Expression is always 'false'
    ///     ...
    ///   }
    /// }
    /// </code></example>
    [AttributeUsage(
      AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property |
      AttributeTargets.Method | AttributeTargets.Delegate)]
    public sealed class NonNegativeValueAttribute : Attribute
    {
    }

    /// <summary>
    /// Indicates that the function argument should be a string literal and match
    /// one of the parameters of the caller function. This annotation is used for paramerers
    /// like 'string paramName' parameter of the <see cref="System.ArgumentNullException"/> constuctor.
    /// </summary>
    /// <example><code>
    /// void Foo(string param) {
    ///   if (param == null)
    ///     throw new ArgumentNullException("par"); // Warning: Cannot resolve symbol
    /// }
    /// </code></example>
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class InvokerParameterNameAttribute : Attribute
    {
    }

    /// <summary>
    /// Indicates that the method is contained in a type that implements
    /// <c>System.ComponentModel.INotifyPropertyChanged</c> interface and this method
    /// is used to notify that some property value changed.
    /// </summary>
    /// <remarks>
    /// The method should be non-static and conform to one of the supported signatures:
    /// <list>
    /// <item><c>NotifyChanged(string)</c></item>
    /// <item><c>NotifyChanged(params string[])</c></item>
    /// <item><c>NotifyChanged{T}(Expression{Func{T}})</c></item>
    /// <item><c>NotifyChanged{T,U}(Expression{Func{T,U}})</c></item>
    /// <item><c>SetProperty{T}(ref T, T, string)</c></item>
    /// </list>
    /// </remarks>
    /// <example><code>
    /// public class Foo : INotifyPropertyChanged {
    ///   public event PropertyChangedEventHandler PropertyChanged;
    ///
    ///   [NotifyPropertyChangedInvocator]
    ///   protected virtual void NotifyChanged(string propertyName) { ... }
    ///
    ///   string _name;
    ///
    ///   public string Name {
    ///     get { return _name; }
    ///     set { _name = value; NotifyChanged("LastName"); /* Warning */ }
    ///   }
    /// }
    /// </code>
    /// Examples of generated notifications:
    /// <list>
    /// <item><c>NotifyChanged("Property")</c></item>
    /// <item><c>NotifyChanged(() =&gt; Property)</c></item>
    /// <item><c>NotifyChanged((VM x) =&gt; x.Property)</c></item>
    /// <item><c>SetProperty(ref myField, value, "Property")</c></item>
    /// </list>
    /// </example>
    [AttributeUsage(AttributeTargets.Method)]
  
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    public NotifyPropertyChangedInvocatorAttribute() { }
After:
    public NotifyPropertyChangedInvocatorAttribute()
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    public NotifyPropertyChangedInvocatorAttribute() { }
After:
    public NotifyPropertyChangedInvocatorAttribute()
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    public NotifyPropertyChangedInvocatorAttribute() { }
After:
    public NotifyPropertyChangedInvocatorAttribute()
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    public NotifyPropertyChangedInvocatorAttribute() { }
After:
    public NotifyPropertyChangedInvocatorAttribute()
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      ParameterName = parameterName;
After:
      this.ParameterName = parameterName;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      ParameterName = parameterName;
After:
      this.ParameterName = parameterName;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      ParameterName = parameterName;
After:
      this.ParameterName = parameterName;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      ParameterName = parameterName;
After:
      this.ParameterName = parameterName;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    [CanBeNull] public string ParameterName { get; }
After:
    [CanBeNull]
        public string ParameterName { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    [CanBeNull] public string ParameterName { get; }
After:
    [CanBeNull]
        public string ParameterName { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    [CanBeNull] public string ParameterName { get; }
After:
    [CanBeNull]
        public string ParameterName { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    [CanBeNull] public string ParameterName { get; }
After:
    [CanBeNull]
        public string ParameterName { get; }
*/
  public sealed class NotifyPropertyChangedInvocatorAttribute : Attribute
    {
        public NotifyPropertyChangedInvocatorAttribute()
        {
        }

        public NotifyPropertyChangedInvocatorAttribute([NotNull] string parameterName)
        {
            this.ParameterName = parameterName;
        }

        [CanBeNull]
        public string ParameterName { get; }
    }

    /// <summary>
    /// Describes dependency between method input and output.
    /// </summary>
    /// <syntax>
    /// <p>Function Definition Table syntax:</p>
    /// <list>
    /// <item>FDT      ::= FDTRow [;FDTRow]*</item>
    /// <item>FDTRow   ::= Input =&gt; Output | Output &lt;= Input</item>
    /// <item>Input    ::= ParameterName: Value [, Input]*</item>
    /// <item>Output   ::= [ParameterName: Value]* {halt|stop|void|nothing|Value}</item>
    /// <item>Value    ::= true | false | null | notnull | canbenull</item>
    /// </list>
    /// If the method has a single input parameter, its name could be omitted.<br/>
    /// Using <c>halt</c> (or <c>void</c>/<c>nothing</c>, which is the same) for the method output
    /// means that the method doesn't return normally (throws or terminates the process).<br/>
    /// Value <c>canbenull</c> is only applicable for output parameters.<br/>
    /// You can use multiple <c>[ContractAnnotation]</c> for each FDT row, or use single attribute
    /// with rows separated by the semicolon. There is no notion of order rows, all rows are checked
    /// for applicability and applied per each program state tracked by the analysis engine.<br/>
    /// </syntax>
    /// <examples><list>
    /// <item><code>
    /// [ContractAnnotation("=&gt; halt")]
    /// public void TerminationMethod()
    /// </code></item>
    /// <item><code>
    /// [ContractAnnotation("null &lt;= param:null")] // reverse condition syntax
    /// public string GetName(string surname)
    /// </code></item>
    /// <item><code>
    /// [ContractAnnotation("s:null =&gt; true")]
    /// public bool IsNullOrEmpty(string s) // string.IsNullOrEmpty()
    /// </code></item>
    /// <item><code>
    /// // A method that returns null if the parameter is null,
    /// // and not null if the parameter is not null
    /// [ContractAnnotation("null =&gt; null; notnull =&gt; notnull")]
    /// public object Transform(object data)
    /// </code></item>
    /// <item><code>
    /// [ContractAnnotation("=&gt; true, result: notnull; =&gt; false, result: null")]
    /// public bool TryParse(string s, out Person result)
    /// </code></item>
    /// </list></examples>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
  
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      : this(contract, false) { }
After:
      : this(contract, false)
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      : this(contract, false) { }
After:
      : this(contract, false)
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      : this(contract, false) { }
After:
      : this(contract, false)
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      : this(contract, false) { }
After:
      : this(contract, false)
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      Contract = contract;
      ForceFullStates = forceFullStates;
After:
      this.Contract = contract;
      this.ForceFullStates = forceFullStates;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      Contract = contract;
      ForceFullStates = forceFullStates;
After:
      this.Contract = contract;
      this.ForceFullStates = forceFullStates;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      Contract = contract;
      ForceFullStates = forceFullStates;
After:
      this.Contract = contract;
      this.ForceFullStates = forceFullStates;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      Contract = contract;
      ForceFullStates = forceFullStates;
After:
      this.Contract = contract;
      this.ForceFullStates = forceFullStates;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    [NotNull] public string Contract { get; }
After:
    [NotNull]
        public string Contract { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    [NotNull] public string Contract { get; }
After:
    [NotNull]
        public string Contract { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    [NotNull] public string Contract { get; }
After:
    [NotNull]
        public string Contract { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    [NotNull] public string Contract { get; }
After:
    [NotNull]
        public string Contract { get; }
*/
  public sealed class ContractAnnotationAttribute : Attribute
    {
        public ContractAnnotationAttribute([NotNull] string contract)
          : this(contract, false)
        {
        }

        public ContractAnnotationAttribute([NotNull] string contract, bool forceFullStates)
        {
            this.Contract = contract;
            this.ForceFullStates = forceFullStates;
        }

        [NotNull]
        public string Contract { get; }

        public bool ForceFullStates { get; }
    }

    /// <summary>
    /// Indicates whether the marked element should be localized.
    /// </summary>
    /// <example><code>
    /// [LocalizationRequiredAttribute(true)]
    /// class Foo {
    ///   string str = "my string"; // Warning: Localizable string
    /// }
    /// </code></example>
    [AttributeUsage(AttributeTargets.All)]
  
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    public LocalizationRequiredAttribute() : this(true) { }
After:
    public LocalizationRequiredAttribute()
        : this(true)
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    public LocalizationRequiredAttribute() : this(true) { }
After:
    public LocalizationRequiredAttribute()
        : this(true)
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    public LocalizationRequiredAttribute() : this(true) { }
After:
    public LocalizationRequiredAttribute()
        : this(true)
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    public LocalizationRequiredAttribute() : this(true) { }
After:
    public LocalizationRequiredAttribute()
        : this(true)
    {
    }
*/
  public sealed class LocalizationRequiredAttribute : Attribute
    {
        public LocalizationRequiredAttribute()
    
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      Required = required;
After:
      this.Required = required;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      Required = required;
After:
      this.Required = required;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      Required = required;
After:
      this.Required = required;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      Required = required;
After:
      this.Required = required;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  /// 
After:
  ///
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  /// 
After:
  ///
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  /// 
After:
  ///
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  /// 
After:
  ///
*/
        : this(true)
        {
        }

        public LocalizationRequiredAttribute(bool required)
        {
            this.Required = required;
        }

        public bool Required { get; }
    }

    /// <summary>
    /// Indicates that the value of the marked type (or its derivatives)
    /// cannot be compared using '==' or '!=' operators and <c>Equals()</c>
    /// should be used instead. However, using '==' or '!=' for comparison
    /// with <c>null</c> is always permitted.
    /// </summary>
    /// <example><code>
    /// [CannotApplyEqualityOperator]
    /// class NoEquality { }
    ///
    /// class UsesNoEquality {
    ///   void Test() {
    ///     var ca1 = new NoEquality();
    ///     var ca2 = new NoEquality();
    ///     if (ca1 != null) { // OK
    ///       bool condition = ca1 == ca2; // Warning
    ///     }
    ///   }
    /// }
    /// </code></example>
    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class | AttributeTargets.Struct)]

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  public sealed class CannotApplyEqualityOperatorAttribute : Attribute { }

  /// <summary>
  /// When applied to a target attribute, specifies a requirement for any type marked
  /// with the target attribute to implement or inherit specific type or types.
  /// </summary>
  /// <example><code>
  /// [BaseTypeRequired(typeof(IComponent)] // Specify requirement
  /// class ComponentAttribute : Attribute { }
  /// 
After:
  public sealed class CannotApplyEqualityOperatorAttribute : Attribute
    {
    }

  /// <summary>
  /// When applied to a target attribute, specifies a requirement for any type marked
  /// with the target attribute to implement or inherit specific type or types.
  /// </summary>
  /// <example><code>
  /// [BaseTypeRequired(typeof(IComponent)] // Specify requirement
  /// class ComponentAttribute : Attribute { }
  ///
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  public sealed class CannotApplyEqualityOperatorAttribute : Attribute { }

  /// <summary>
  /// When applied to a target attribute, specifies a requirement for any type marked
  /// with the target attribute to implement or inherit specific type or types.
  /// </summary>
  /// <example><code>
  /// [BaseTypeRequired(typeof(IComponent)] // Specify requirement
  /// class ComponentAttribute : Attribute { }
  /// 
After:
  public sealed class CannotApplyEqualityOperatorAttribute : Attribute
    {
    }

  /// <summary>
  /// When applied to a target attribute, specifies a requirement for any type marked
  /// with the target attribute to implement or inherit specific type or types.
  /// </summary>
  /// <example><code>
  /// [BaseTypeRequired(typeof(IComponent)] // Specify requirement
  /// class ComponentAttribute : Attribute { }
  ///
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  public sealed class CannotApplyEqualityOperatorAttribute : Attribute { }

  /// <summary>
  /// When applied to a target attribute, specifies a requirement for any type marked
  /// with the target attribute to implement or inherit specific type or types.
  /// </summary>
  /// <example><code>
  /// [BaseTypeRequired(typeof(IComponent)] // Specify requirement
  /// class ComponentAttribute : Attribute { }
  /// 
After:
  public sealed class CannotApplyEqualityOperatorAttribute : Attribute
    {
    }

  /// <summary>
  /// When applied to a target attribute, specifies a requirement for any type marked
  /// with the target attribute to implement or inherit specific type or types.
  /// </summary>
  /// <example><code>
  /// [BaseTypeRequired(typeof(IComponent)] // Specify requirement
  /// class ComponentAttribute : Attribute { }
  ///
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  public sealed class CannotApplyEqualityOperatorAttribute : Attribute { }

  /// <summary>
  /// When applied to a target attribute, specifies a requirement for any type marked
  /// with the target attribute to implement or inherit specific type or types.
  /// </summary>
  /// <example><code>
  /// [BaseTypeRequired(typeof(IComponent)] // Specify requirement
  /// class ComponentAttribute : Attribute { }
  /// 
After:
  public sealed class CannotApplyEqualityOperatorAttribute : Attribute
    {
    }

  /// <summary>
  /// When applied to a target attribute, specifies a requirement for any type marked
  /// with the target attribute to implement or inherit specific type or types.
  /// </summary>
  /// <example><code>
  /// [BaseTypeRequired(typeof(IComponent)] // Specify requirement
  /// class ComponentAttribute : Attribute { }
  ///
*/
    public sealed class CannotApplyEqualityOperatorAttribute : Attribute
    {
    }

    /// <summary>
    /// When applied to a target attribute, specifies a requirement for any type marked
    /// with the target attribute to implement or inherit specific type or types.
    /// </summary>
    /// <example><code>
    /// [BaseTypeRequired(typeof(IComponent)] // Specify requirement
    /// class ComponentAttribute : Attribute { }
    ///
    /// [Component] // ComponentAttribute requires implementing IComponent interface
    /// class MyComponent : IComponent { }
    /// </code></example>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    [BaseTypeRequired(typeof(Attribute))]
  
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      BaseType = baseType;
After:
      this.BaseType = baseType;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      BaseType = baseType;
After:
      this.BaseType = baseType;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      BaseType = baseType;
After:
      this.BaseType = baseType;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      BaseType = baseType;
After:
      this.BaseType = baseType;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    [NotNull] public Type BaseType { get; }
After:
    [NotNull]
        public Type BaseType { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    [NotNull] public Type BaseType { get; }
After:
    [NotNull]
        public Type BaseType { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    [NotNull] public Type BaseType { get; }
After:
    [NotNull]
        public Type BaseType { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    [NotNull] public Type BaseType { get; }
After:
    [NotNull]
        public Type BaseType { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  /// 
  /// public class SummaryData
  /// {
  ///   [UsedImplicitly(ImplicitUseKindFlags.InstantiatedWithFixedConstructorSignature)]
  ///   public SummaryData() {}
  /// }
  /// 
After:
  ///
  /// public class SummaryData
  /// {
  ///   [UsedImplicitly(ImplicitUseKindFlags.InstantiatedWithFixedConstructorSignature)]
  ///   public SummaryData() {}
  /// }
  ///
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  /// 
  /// public class SummaryData
  /// {
  ///   [UsedImplicitly(ImplicitUseKindFlags.InstantiatedWithFixedConstructorSignature)]
  ///   public SummaryData() {}
  /// }
  /// 
After:
  ///
  /// public class SummaryData
  /// {
  ///   [UsedImplicitly(ImplicitUseKindFlags.InstantiatedWithFixedConstructorSignature)]
  ///   public SummaryData() {}
  /// }
  ///
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  /// 
  /// public class SummaryData
  /// {
  ///   [UsedImplicitly(ImplicitUseKindFlags.InstantiatedWithFixedConstructorSignature)]
  ///   public SummaryData() {}
  /// }
  /// 
After:
  ///
  /// public class SummaryData
  /// {
  ///   [UsedImplicitly(ImplicitUseKindFlags.InstantiatedWithFixedConstructorSignature)]
  ///   public SummaryData() {}
  /// }
  ///
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  /// 
  /// public class SummaryData
  /// {
  ///   [UsedImplicitly(ImplicitUseKindFlags.InstantiatedWithFixedConstructorSignature)]
  ///   public SummaryData() {}
  /// }
  /// 
After:
  ///
  /// public class SummaryData
  /// {
  ///   [UsedImplicitly(ImplicitUseKindFlags.InstantiatedWithFixedConstructorSignature)]
  ///   public SummaryData() {}
  /// }
  ///
*/
  public sealed class BaseTypeRequiredAttribute : Attribute
    {
        public BaseTypeRequiredAttribute([NotNull] Type baseType)
        {
            this.BaseType = baseType;
        }

        [NotNull]
        public Type BaseType { get; }
    }

    /// <summary>
    /// Indicates that the marked symbol is used implicitly (e.g. via reflection, in external library),
    /// so this symbol will be ignored by usage-checking inspections. <br/>
    /// You can use <see cref="ImplicitUseKindFlags"/> and <see cref="ImplicitUseTargetFlags"/>
    /// to configure how this attribute is applied.
    /// </summary>
    /// <example><code>
    /// [UsedImplicitly]
    /// public class TypeConverter {}
    ///
    /// public class SummaryData
    /// {
    ///   [UsedImplicitly(ImplicitUseKindFlags.InstantiatedWithFixedConstructorSignature)]
    ///   public SummaryData() {}
    /// }
    ///
    /// [UsedImplicitly(ImplicitUseTargetFlags.WithInheritors | ImplicitUseTargetFlags.Default)]
    /// public interface IService {}
    /// </code></example>
    [AttributeUsage(AttributeTargets.All)]
  
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default) { }

    public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags)
      : this(useKindFlags, ImplicitUseTargetFlags.Default) { }

    public UsedImplicitlyAttribute(ImplicitUseTargetFlags targetFlags)
      : this(ImplicitUseKindFlags.Default, targetFlags) { }
After:
      : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default)
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default) { }

    public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags)
      : this(useKindFlags, ImplicitUseTargetFlags.Default) { }

    public UsedImplicitlyAttribute(ImplicitUseTargetFlags targetFlags)
      : this(ImplicitUseKindFlags.Default, targetFlags) { }
After:
      : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default)
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default) { }

    public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags)
      : this(useKindFlags, ImplicitUseTargetFlags.Default) { }

    public UsedImplicitlyAttribute(ImplicitUseTargetFlags targetFlags)
      : this(ImplicitUseKindFlags.Default, targetFlags) { }
After:
      : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default)
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default) { }

    public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags)
      : this(useKindFlags, ImplicitUseTargetFlags.Default) { }

    public UsedImplicitlyAttribute(ImplicitUseTargetFlags targetFlags)
      : this(ImplicitUseKindFlags.Default, targetFlags) { }
After:
      : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default)
    {
    }
*/
  public sealed class UsedImplicitlyAttribute : Attribute
    {
    
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
    {
      UseKindFlags = useKindFlags;
      TargetFlags = targetFlags;
After:
    public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags)
      : this(useKindFlags, ImplicitUseTargetFlags.Default)
    {
    }

    public UsedImplicitlyAttribute(ImplicitUseTargetFlags targetFlags)
      : this(ImplicitUseKindFlags.Default, targetFlags)
    {
    }

    public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
    {
      this.UseKindFlags = useKindFlags;
      this.TargetFlags = targetFlags;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
    {
      UseKindFlags = useKindFlags;
      TargetFlags = targetFlags;
After:
    public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags)
      : this(useKindFlags, ImplicitUseTargetFlags.Default)
    {
    }

    public UsedImplicitlyAttribute(ImplicitUseTargetFlags targetFlags)
      : this(ImplicitUseKindFlags.Default, targetFlags)
    {
    }

    public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
    {
      this.UseKindFlags = useKindFlags;
      this.TargetFlags = targetFlags;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
    {
      UseKindFlags = useKindFlags;
      TargetFlags = targetFlags;
After:
    public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags)
      : this(useKindFlags, ImplicitUseTargetFlags.Default)
    {
    }

    public UsedImplicitlyAttribute(ImplicitUseTargetFlags targetFlags)
      : this(ImplicitUseKindFlags.Default, targetFlags)
    {
    }

    public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
    {
      this.UseKindFlags = useKindFlags;
      this.TargetFlags = targetFlags;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
    {
      UseKindFlags = useKindFlags;
      TargetFlags = targetFlags;
After:
    public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags)
      : this(useKindFlags, ImplicitUseTargetFlags.Default)
    {
    }

    public UsedImplicitlyAttribute(ImplicitUseTargetFlags targetFlags)
      : this(ImplicitUseKindFlags.Default, targetFlags)
    {
    }

    public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
    {
      this.UseKindFlags = useKindFlags;
      this.TargetFlags = targetFlags;
*/
    public UsedImplicitlyAttribute()
          : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default)
        {
        }

        public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags)
          : this(useKindFlags, ImplicitUseTargetFlags.Default)
        {
        }

        public UsedImplicitlyAttribute(ImplicitUseTargetFlags targetFlags)
          : this(ImplicitUseKindFlags.Default, targetFlags)
        {
        }

        public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
        {
            this.UseKindFlags = useKindFlags;
            this.TargetFlags = targetFlags;
        }

        public ImplicitUseKindFlags UseKindFlags { get; }

        public ImplicitUseTargetFlags TargetFlags { get; }
    }

    /// <summary>
    /// Can be applied to attributes, type parameters, and parameters of a type assignable from <see cref="System.Type"/> .
    /// When applied to an attribute, the decorated attribute behaves the same as <see cref="UsedImplicitlyAttribute"/>.
    /// When applied to a type parameter or to a parameter of type <see cref="System.Type"/>,
    /// indicates that the corresponding type is used implicitly.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.GenericParameter | AttributeTargets.Parameter)]
  
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default) { }

    public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags)
      : this(useKindFlags, ImplicitUseTargetFlags.Default) { }

    public MeansImplicitUseAttribute(ImplicitUseTargetFlags targetFlags)
      : this(ImplicitUseKindFlags.Default, targetFlags) { }
After:
      : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default)
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default) { }

    public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags)
      : this(useKindFlags, ImplicitUseTargetFlags.Default) { }

    public MeansImplicitUseAttribute(ImplicitUseTargetFlags targetFlags)
      : this(ImplicitUseKindFlags.Default, targetFlags) { }
After:
      : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default)
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default) { }

    public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags)
      : this(useKindFlags, ImplicitUseTargetFlags.Default) { }

    public MeansImplicitUseAttribute(ImplicitUseTargetFlags targetFlags)
      : this(ImplicitUseKindFlags.Default, targetFlags) { }
After:
      : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default)
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default) { }

    public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags)
      : this(useKindFlags, ImplicitUseTargetFlags.Default) { }

    public MeansImplicitUseAttribute(ImplicitUseTargetFlags targetFlags)
      : this(ImplicitUseKindFlags.Default, targetFlags) { }
After:
      : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default)
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
    {
      UseKindFlags = useKindFlags;
      TargetFlags = targetFlags;
After:
    public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags)
      : this(useKindFlags, ImplicitUseTargetFlags.Default)
    {
    }

    public MeansImplicitUseAttribute(ImplicitUseTargetFlags targetFlags)
      : this(ImplicitUseKindFlags.Default, targetFlags)
    {
    }

    public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
    {
      this.UseKindFlags = useKindFlags;
      this.TargetFlags = targetFlags;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
    {
      UseKindFlags = useKindFlags;
      TargetFlags = targetFlags;
After:
    public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags)
      : this(useKindFlags, ImplicitUseTargetFlags.Default)
    {
    }

    public MeansImplicitUseAttribute(ImplicitUseTargetFlags targetFlags)
      : this(ImplicitUseKindFlags.Default, targetFlags)
    {
    }

    public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
    {
      this.UseKindFlags = useKindFlags;
      this.TargetFlags = targetFlags;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
    {
      UseKindFlags = useKindFlags;
      TargetFlags = targetFlags;
After:
    public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags)
      : this(useKindFlags, ImplicitUseTargetFlags.Default)
    {
    }

    public MeansImplicitUseAttribute(ImplicitUseTargetFlags targetFlags)
      : this(ImplicitUseKindFlags.Default, targetFlags)
    {
    }

    public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
    {
      this.UseKindFlags = useKindFlags;
      this.TargetFlags = targetFlags;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
    {
      UseKindFlags = useKindFlags;
      TargetFlags = targetFlags;
After:
    public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags)
      : this(useKindFlags, ImplicitUseTargetFlags.Default)
    {
    }

    public MeansImplicitUseAttribute(ImplicitUseTargetFlags targetFlags)
      : this(ImplicitUseKindFlags.Default, targetFlags)
    {
    }

    public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
    {
      this.UseKindFlags = useKindFlags;
      this.TargetFlags = targetFlags;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    [UsedImplicitly] public ImplicitUseKindFlags UseKindFlags { get; }
After:
    [UsedImplicitly]
        public ImplicitUseKindFlags UseKindFlags { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    [UsedImplicitly] public ImplicitUseKindFlags UseKindFlags { get; }
After:
    [UsedImplicitly]
        public ImplicitUseKindFlags UseKindFlags { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    [UsedImplicitly] public ImplicitUseKindFlags UseKindFlags { get; }
After:
    [UsedImplicitly]
        public ImplicitUseKindFlags UseKindFlags { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    [UsedImplicitly] public ImplicitUseKindFlags UseKindFlags { get; }
After:
    [UsedImplicitly]
        public ImplicitUseKindFlags UseKindFlags { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    [UsedImplicitly] public ImplicitUseTargetFlags TargetFlags { get; }
After:
    [UsedImplicitly]
        public ImplicitUseTargetFlags TargetFlags { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    [UsedImplicitly] public ImplicitUseTargetFlags TargetFlags { get; }
After:
    [UsedImplicitly]
        public ImplicitUseTargetFlags TargetFlags { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    [UsedImplicitly] public ImplicitUseTargetFlags TargetFlags { get; }
After:
    [UsedImplicitly]
        public ImplicitUseTargetFlags TargetFlags { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    [UsedImplicitly] public ImplicitUseTargetFlags TargetFlags { get; }
After:
    [UsedImplicitly]
        public ImplicitUseTargetFlags TargetFlags { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  /// Specifies the details of implicitly used symbol when it is marked
  /// with <see cref="MeansImplicitUseAttribute"/> or <see cref="UsedImplicitlyAttribute"/>.
  /// </summary>
  [Flags]
  public enum ImplicitUseKindFlags
  {
    Default = Access | Assign | InstantiatedWithFixedConstructorSignature,
    /// <summary>Only entity marked with attribute considered used.</summary>
    Access = 1,
    /// <summary>Indicates implicit assignment to a member.</summary>
    Assign = 2,
    /// <summary>
    /// Indicates implicit instantiation of a type with fixed constructor signature.
    /// That means any unused constructor parameters won't be reported as such.
    /// </summary>
    InstantiatedWithFixedConstructorSignature = 4,
    /// <summary>Indicates implicit instantiation of a type.</summary>
    InstantiatedNoFixedConstructorSignature = 8,
  }

  /// <summary>
  /// Specifies what is considered to be used implicitly when marked
After:
  /// Specifies what is considered to be used implicitly when marked
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  /// Specifies the details of implicitly used symbol when it is marked
  /// with <see cref="MeansImplicitUseAttribute"/> or <see cref="UsedImplicitlyAttribute"/>.
  /// </summary>
  [Flags]
  public enum ImplicitUseKindFlags
  {
    Default = Access | Assign | InstantiatedWithFixedConstructorSignature,
    /// <summary>Only entity marked with attribute considered used.</summary>
    Access = 1,
    /// <summary>Indicates implicit assignment to a member.</summary>
    Assign = 2,
    /// <summary>
    /// Indicates implicit instantiation of a type with fixed constructor signature.
    /// That means any unused constructor parameters won't be reported as such.
    /// </summary>
    InstantiatedWithFixedConstructorSignature = 4,
    /// <summary>Indicates implicit instantiation of a type.</summary>
    InstantiatedNoFixedConstructorSignature = 8,
  }

  /// <summary>
  /// Specifies what is considered to be used implicitly when marked
After:
  /// Specifies what is considered to be used implicitly when marked
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  /// Specifies the details of implicitly used symbol when it is marked
  /// with <see cref="MeansImplicitUseAttribute"/> or <see cref="UsedImplicitlyAttribute"/>.
  /// </summary>
  [Flags]
  public enum ImplicitUseKindFlags
  {
    Default = Access | Assign | InstantiatedWithFixedConstructorSignature,
    /// <summary>Only entity marked with attribute considered used.</summary>
    Access = 1,
    /// <summary>Indicates implicit assignment to a member.</summary>
    Assign = 2,
    /// <summary>
    /// Indicates implicit instantiation of a type with fixed constructor signature.
    /// That means any unused constructor parameters won't be reported as such.
    /// </summary>
    InstantiatedWithFixedConstructorSignature = 4,
    /// <summary>Indicates implicit instantiation of a type.</summary>
    InstantiatedNoFixedConstructorSignature = 8,
  }

  /// <summary>
  /// Specifies what is considered to be used implicitly when marked
After:
  /// Specifies what is considered to be used implicitly when marked
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  /// Specifies the details of implicitly used symbol when it is marked
  /// with <see cref="MeansImplicitUseAttribute"/> or <see cref="UsedImplicitlyAttribute"/>.
  /// </summary>
  [Flags]
  public enum ImplicitUseKindFlags
  {
    Default = Access | Assign | InstantiatedWithFixedConstructorSignature,
    /// <summary>Only entity marked with attribute considered used.</summary>
    Access = 1,
    /// <summary>Indicates implicit assignment to a member.</summary>
    Assign = 2,
    /// <summary>
    /// Indicates implicit instantiation of a type with fixed constructor signature.
    /// That means any unused constructor parameters won't be reported as such.
    /// </summary>
    InstantiatedWithFixedConstructorSignature = 4,
    /// <summary>Indicates implicit instantiation of a type.</summary>
    InstantiatedNoFixedConstructorSignature = 8,
  }

  /// <summary>
  /// Specifies what is considered to be used implicitly when marked
After:
  /// Specifies what is considered to be used implicitly when marked
*/
  public sealed class MeansImplicitUseAttribute : Attribute
    {
        public MeansImplicitUseAttribute()
          : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default)
        {
        }

        public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags)
          : this(useKindFlags, ImplicitUseTargetFlags.Default)
        {
        }

        public MeansImplicitUseAttribute(ImplicitUseTargetFlags targetFlags)
          : this(ImplicitUseKindFlags.Default, targetFlags)
        {
        }

        public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
        {
            this.UseKindFlags = useKindFlags;
            this.TargetFlags = targetFlags;
        }

        [UsedImplicitly]
        public ImplicitUseKindFlags UseKindFlags { get; }

        [UsedImplicitly]
        public ImplicitUseTargetFlags TargetFlags { get; }
    }

    /// <summary>
    /// Specifies what is considered to be used implicitly when marked
    /// with <see cref="MeansImplicitUseAttribute"/> or <see cref="UsedImplicitlyAttribute"/>.
    /// </summary>
    [Flags]
    public enum ImplicitUseTargetFlags
    {
        Default = Itself,
        Itself = 1,

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    /// <summary>Members of the type marked with the attribute are considered used.</summary>
After:
    /// <summary>Members of the type marked with the attribute are considered used.</summary>
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    /// <summary>Members of the type marked with the attribute are considered used.</summary>
After:
    /// <summary>Members of the type marked with the attribute are considered used.</summary>
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    /// <summary>Members of the type marked with the attribute are considered used.</summary>
After:
    /// <summary>Members of the type marked with the attribute are considered used.</summary>
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    /// <summary>Members of the type marked with the attribute are considered used.</summary>
After:
    /// <summary>Members of the type marked with the attribute are considered used.</summary>
*/

        /// <summary>Members of the type marked with the attribute are considered used.</summary>
        Members = 2,

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    /// <summary> Inherited entities are considered used. </summary>
After:
    /// <summary> Inherited entities are considered used. </summary>
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    /// <summary> Inherited entities are considered used. </summary>
After:
    /// <summary> Inherited entities are considered used. </summary>
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    /// <summary> Inherited entities are considered used. </summary>
After:
    /// <summary> Inherited entities are considered used. </summary>
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    /// <summary> Inherited entities are considered used. </summary>
After:
    /// <summary> Inherited entities are considered used. </summary>
*/

        /// <summary> Inherited entities are considered used. </summary>
        WithInheritors = 4,

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    /// <summary>Entity marked with the attribute and all its members considered used.</summary>
    WithMembers = Itself | Members
After:
    /// <summary>Entity marked with the attribute and all its members considered used.</summary>
    WithMembers = Itself | Members,
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    /// <summary>Entity marked with the attribute and all its members considered used.</summary>
    WithMembers = Itself | Members
After:
    /// <summary>Entity marked with the attribute and all its members considered used.</summary>
    WithMembers = Itself | Members,
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    /// <summary>Entity marked with the attribute and all its members considered used.</summary>
    WithMembers = Itself | Members
After:
    /// <summary>Entity marked with the attribute and all its members considered used.</summary>
    WithMembers = Itself | Members,
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    /// <summary>Entity marked with the attribute and all its members considered used.</summary>
    WithMembers = Itself | Members
After:
    /// <summary>Entity marked with the attribute and all its members considered used.</summary>
    WithMembers = Itself | Members,
*/

        /// <summary>Entity marked with the attribute and all its members considered used.</summary>
        WithMembers = Itself | Members
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  /// This attribute is intended to mark publicly available API,
After:
  /// Provides a value for the <see cref="CollectionAccessAttribute"/> to define
  /// how the collection method invocation affects the contents of the collection.
  /// </summary>
  [Flags]
  public enum CollectionAccessType
  {
    /// <summary>Method does not use or modify content of the collection.</summary>
    None = 0,

    /// <summary>Method only reads content of the collection but does not modify it.</summary>
    Read = 1,

    /// <summary>Method can change content of the collection but does not add new elements.</summary>
    ModifyExistingContent = 2,

    /// <summary>Method can add new elements to the collection.</summary>
    UpdatedContent = ModifyExistingContent | 4,
  }

  /// <summary>
  /// Specifies assertion type. If the assertion method argument satisfies the condition,
  /// then the execution continues. Otherwise, execution is assumed to be halted.
  /// </summary>
  public enum AssertionConditionType
  {
    /// <summary>Marked parameter should be evaluated to true.</summary>
    IS_TRUE = 0,

    /// <summary>Marked parameter should be evaluated to false.</summary>
    IS_FALSE = 1,

    /// <summary>Marked parameter should be evaluated to null value.</summary>
    IS_NULL = 2,

    /// <summary>Marked parameter should be evaluated to not null value.</summary>
    IS_NOT_NULL = 3,
  }

  /// <summary>
  /// Language of injected code fragment inside marked by <see cref="LanguageInjectionAttribute"/> string literal.
  /// </summary>
  public enum InjectedLanguage
  {
    CSS,
    HTML,
    JAVASCRIPT,
    JSON,
    XML,
  }

  /// <summary>
  /// This attribute is intended to mark publicly available API,
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  /// This attribute is intended to mark publicly available API,
After:
  /// Provides a value for the <see cref="CollectionAccessAttribute"/> to define
  /// how the collection method invocation affects the contents of the collection.
  /// </summary>
  [Flags]
  public enum CollectionAccessType
  {
    /// <summary>Method does not use or modify content of the collection.</summary>
    None = 0,

    /// <summary>Method only reads content of the collection but does not modify it.</summary>
    Read = 1,

    /// <summary>Method can change content of the collection but does not add new elements.</summary>
    ModifyExistingContent = 2,

    /// <summary>Method can add new elements to the collection.</summary>
    UpdatedContent = ModifyExistingContent | 4,
  }

  /// <summary>
  /// Specifies assertion type. If the assertion method argument satisfies the condition,
  /// then the execution continues. Otherwise, execution is assumed to be halted.
  /// </summary>
  public enum AssertionConditionType
  {
    /// <summary>Marked parameter should be evaluated to true.</summary>
    IS_TRUE = 0,

    /// <summary>Marked parameter should be evaluated to false.</summary>
    IS_FALSE = 1,

    /// <summary>Marked parameter should be evaluated to null value.</summary>
    IS_NULL = 2,

    /// <summary>Marked parameter should be evaluated to not null value.</summary>
    IS_NOT_NULL = 3,
  }

  /// <summary>
  /// Language of injected code fragment inside marked by <see cref="LanguageInjectionAttribute"/> string literal.
  /// </summary>
  public enum InjectedLanguage
  {
    CSS,
    HTML,
    JAVASCRIPT,
    JSON,
    XML,
  }

  /// <summary>
  /// This attribute is intended to mark publicly available API,
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  /// This attribute is intended to mark publicly available API,
After:
  /// Provides a value for the <see cref="CollectionAccessAttribute"/> to define
  /// how the collection method invocation affects the contents of the collection.
  /// </summary>
  [Flags]
  public enum CollectionAccessType
  {
    /// <summary>Method does not use or modify content of the collection.</summary>
    None = 0,

    /// <summary>Method only reads content of the collection but does not modify it.</summary>
    Read = 1,

    /// <summary>Method can change content of the collection but does not add new elements.</summary>
    ModifyExistingContent = 2,

    /// <summary>Method can add new elements to the collection.</summary>
    UpdatedContent = ModifyExistingContent | 4,
  }

  /// <summary>
  /// Specifies assertion type. If the assertion method argument satisfies the condition,
  /// then the execution continues. Otherwise, execution is assumed to be halted.
  /// </summary>
  public enum AssertionConditionType
  {
    /// <summary>Marked parameter should be evaluated to true.</summary>
    IS_TRUE = 0,

    /// <summary>Marked parameter should be evaluated to false.</summary>
    IS_FALSE = 1,

    /// <summary>Marked parameter should be evaluated to null value.</summary>
    IS_NULL = 2,

    /// <summary>Marked parameter should be evaluated to not null value.</summary>
    IS_NOT_NULL = 3,
  }

  /// <summary>
  /// Language of injected code fragment inside marked by <see cref="LanguageInjectionAttribute"/> string literal.
  /// </summary>
  public enum InjectedLanguage
  {
    CSS,
    HTML,
    JAVASCRIPT,
    JSON,
    XML,
  }

  /// <summary>
  /// This attribute is intended to mark publicly available API,
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  /// This attribute is intended to mark publicly available API,
After:
  /// Provides a value for the <see cref="CollectionAccessAttribute"/> to define
  /// how the collection method invocation affects the contents of the collection.
  /// </summary>
  [Flags]
  public enum CollectionAccessType
  {
    /// <summary>Method does not use or modify content of the collection.</summary>
    None = 0,

    /// <summary>Method only reads content of the collection but does not modify it.</summary>
    Read = 1,

    /// <summary>Method can change content of the collection but does not add new elements.</summary>
    ModifyExistingContent = 2,

    /// <summary>Method can add new elements to the collection.</summary>
    UpdatedContent = ModifyExistingContent | 4,
  }

  /// <summary>
  /// Specifies assertion type. If the assertion method argument satisfies the condition,
  /// then the execution continues. Otherwise, execution is assumed to be halted.
  /// </summary>
  public enum AssertionConditionType
  {
    /// <summary>Marked parameter should be evaluated to true.</summary>
    IS_TRUE = 0,

    /// <summary>Marked parameter should be evaluated to false.</summary>
    IS_FALSE = 1,

    /// <summary>Marked parameter should be evaluated to null value.</summary>
    IS_NULL = 2,

    /// <summary>Marked parameter should be evaluated to not null value.</summary>
    IS_NOT_NULL = 3,
  }

  /// <summary>
  /// Language of injected code fragment inside marked by <see cref="LanguageInjectionAttribute"/> string literal.
  /// </summary>
  public enum InjectedLanguage
  {
    CSS,
    HTML,
    JAVASCRIPT,
    JSON,
    XML,
  }

  /// <summary>
  /// This attribute is intended to mark publicly available API,
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    public PublicAPIAttribute() { }
After:
    public PublicAPIAttribute()
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    public PublicAPIAttribute() { }
After:
    public PublicAPIAttribute()
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    public PublicAPIAttribute() { }
After:
    public PublicAPIAttribute()
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    public PublicAPIAttribute() { }
After:
    public PublicAPIAttribute()
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      Comment = comment;
After:
      this.Comment = comment;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      Comment = comment;
After:
      this.Comment = comment;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      Comment = comment;
After:
      this.Comment = comment;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      Comment = comment;
After:
      this.Comment = comment;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    [CanBeNull] public string Comment { get; }
After:
    [CanBeNull]
        public string Comment { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    [CanBeNull] public string Comment { get; }
After:
    [CanBeNull]
        public string Comment { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    [CanBeNull] public string Comment { get; }
After:
    [CanBeNull]
        public string Comment { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    [CanBeNull] public string Comment { get; }
After:
    [CanBeNull]
        public string Comment { get; }
*/
,
    }

    /// <summary>
    /// Provides a value for the <see cref="CollectionAccessAttribute"/> to define
    /// how the collection method invocation affects the contents of the collection.
    /// </summary>
    [Flags]
  
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    /// Require the method invocation to be used under the 'await' expression for this attribute to take effect on code analysis engine.
After:
    /// Gets or sets a value indicating whether require the method invocation to be used under the 'await' expression for this attribute to take effect on code analysis engine.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    /// Require the method invocation to be used under the 'await' expression for this attribute to take effect on code analysis engine.
After:
    /// Gets or sets a value indicating whether require the method invocation to be used under the 'await' expression for this attribute to take effect on code analysis engine.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    /// Require the method invocation to be used under the 'await' expression for this attribute to take effect on code analysis engine.
After:
    /// Gets or sets a value indicating whether require the method invocation to be used under the 'await' expression for this attribute to take effect on code analysis engine.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    /// Require the method invocation to be used under the 'await' expression for this attribute to take effect on code analysis engine.
After:
    /// Gets or sets a value indicating whether require the method invocation to be used under the 'await' expression for this attribute to take effect on code analysis engine.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  /// 
After:
  ///
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  /// 
After:
  ///
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  /// 
After:
  ///
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  /// 
After:
  ///
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  public sealed class PureAttribute : Attribute { }
After:
  public sealed class PureAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  public sealed class PureAttribute : Attribute { }
After:
  public sealed class PureAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  public sealed class PureAttribute : Attribute { }
After:
  public sealed class PureAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  public sealed class PureAttribute : Attribute { }
After:
  public sealed class PureAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    public MustUseReturnValueAttribute() { }
After:
    public MustUseReturnValueAttribute()
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    public MustUseReturnValueAttribute() { }
After:
    public MustUseReturnValueAttribute()
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    public MustUseReturnValueAttribute() { }
After:
    public MustUseReturnValueAttribute()
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    public MustUseReturnValueAttribute() { }
After:
    public MustUseReturnValueAttribute()
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      Justification = justification;
After:
      this.Justification = justification;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      Justification = justification;
After:
      this.Justification = justification;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      Justification = justification;
After:
      this.Justification = justification;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      Justification = justification;
After:
      this.Justification = justification;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    [CanBeNull] public string Justification { get; }
After:
    [CanBeNull]
        public string Justification { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    [CanBeNull] public string Justification { get; }
After:
    [CanBeNull]
        public string Justification { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    [CanBeNull] public string Justification { get; }
After:
    [CanBeNull]
        public string Justification { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    [CanBeNull] public string Justification { get; }
After:
    [CanBeNull]
        public string Justification { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  /// 
After:
  ///
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  /// 
After:
  ///
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  /// 
After:
  ///
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  /// 
After:
  ///
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  public sealed class ProvidesContextAttribute : Attribute { }
After:
  public sealed class ProvidesContextAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  public sealed class ProvidesContextAttribute : Attribute { }
After:
  public sealed class ProvidesContextAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  public sealed class ProvidesContextAttribute : Attribute { }
After:
  public sealed class ProvidesContextAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  public sealed class ProvidesContextAttribute : Attribute { }
After:
  public sealed class ProvidesContextAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    public PathReferenceAttribute() { }
After:
    public PathReferenceAttribute()
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    public PathReferenceAttribute() { }
After:
    public PathReferenceAttribute()
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    public PathReferenceAttribute() { }
After:
    public PathReferenceAttribute()
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    public PathReferenceAttribute() { }
After:
    public PathReferenceAttribute()
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      BasePath = basePath;
After:
      this.BasePath = basePath;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      BasePath = basePath;
After:
      this.BasePath = basePath;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      BasePath = basePath;
After:
      this.BasePath = basePath;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      BasePath = basePath;
After:
      this.BasePath = basePath;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    [CanBeNull] public string BasePath { get; }
After:
    [CanBeNull]
        public string BasePath { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    [CanBeNull] public string BasePath { get; }
After:
    [CanBeNull]
        public string BasePath { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    [CanBeNull] public string BasePath { get; }
After:
    [CanBeNull]
        public string BasePath { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    [CanBeNull] public string BasePath { get; }
After:
    [CanBeNull]
        public string BasePath { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  public sealed class SourceTemplateAttribute : Attribute { }
After:
  public sealed class SourceTemplateAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  public sealed class SourceTemplateAttribute : Attribute { }
After:
  public sealed class SourceTemplateAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  public sealed class SourceTemplateAttribute : Attribute { }
After:
  public sealed class SourceTemplateAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  public sealed class SourceTemplateAttribute : Attribute { }
After:
  public sealed class SourceTemplateAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    /// Allows specifying a macro that will be executed for a <see cref="SourceTemplateAttribute">source template</see>
After:
    /// Gets or sets allows specifying a macro that will be executed for a <see cref="SourceTemplateAttribute">source template</see>
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    /// Allows specifying a macro that will be executed for a <see cref="SourceTemplateAttribute">source template</see>
After:
    /// Gets or sets allows specifying a macro that will be executed for a <see cref="SourceTemplateAttribute">source template</see>
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    /// Allows specifying a macro that will be executed for a <see cref="SourceTemplateAttribute">source template</see>
After:
    /// Gets or sets allows specifying a macro that will be executed for a <see cref="SourceTemplateAttribute">source template</see>
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    /// Allows specifying a macro that will be executed for a <see cref="SourceTemplateAttribute">source template</see>
After:
    /// Gets or sets allows specifying a macro that will be executed for a <see cref="SourceTemplateAttribute">source template</see>
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    [CanBeNull] public string Expression { get; set; }
After:
    [CanBeNull]
        public string Expression { get; set; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    [CanBeNull] public string Expression { get; set; }
After:
    [CanBeNull]
        public string Expression { get; set; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    [CanBeNull] public string Expression { get; set; }
After:
    [CanBeNull]
        public string Expression { get; set; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    [CanBeNull] public string Expression { get; set; }
After:
    [CanBeNull]
        public string Expression { get; set; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    /// Allows specifying which occurrence of the target parameter becomes editable when the template is deployed.
After:
    /// Gets or sets allows specifying which occurrence of the target parameter becomes editable when the template is deployed.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    /// Allows specifying which occurrence of the target parameter becomes editable when the template is deployed.
After:
    /// Gets or sets allows specifying which occurrence of the target parameter becomes editable when the template is deployed.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    /// Allows specifying which occurrence of the target parameter becomes editable when the template is deployed.
After:
    /// Gets or sets allows specifying which occurrence of the target parameter becomes editable when the template is deployed.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    /// Allows specifying which occurrence of the target parameter becomes editable when the template is deployed.
After:
    /// Gets or sets allows specifying which occurrence of the target parameter becomes editable when the template is deployed.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    /// Identifies the target parameter of a <see cref="SourceTemplateAttribute">source template</see> if the
    /// <see cref="MacroAttribute"/> is applied on a template method.
    /// </summary>
    [CanBeNull] public string Target { get; set; }
After:
    /// Gets or sets identifies the target parameter of a <see cref="SourceTemplateAttribute">source template</see> if the
    /// <see cref="MacroAttribute"/> is applied on a template method.
    /// </summary>
    [CanBeNull]
        public string Target { get; set; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    /// Identifies the target parameter of a <see cref="SourceTemplateAttribute">source template</see> if the
    /// <see cref="MacroAttribute"/> is applied on a template method.
    /// </summary>
    [CanBeNull] public string Target { get; set; }
After:
    /// Gets or sets identifies the target parameter of a <see cref="SourceTemplateAttribute">source template</see> if the
    /// <see cref="MacroAttribute"/> is applied on a template method.
    /// </summary>
    [CanBeNull]
        public string Target { get; set; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    /// Identifies the target parameter of a <see cref="SourceTemplateAttribute">source template</see> if the
    /// <see cref="MacroAttribute"/> is applied on a template method.
    /// </summary>
    [CanBeNull] public string Target { get; set; }
After:
    /// Gets or sets identifies the target parameter of a <see cref="SourceTemplateAttribute">source template</see> if the
    /// <see cref="MacroAttribute"/> is applied on a template method.
    /// </summary>
    [CanBeNull]
        public string Target { get; set; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    /// Identifies the target parameter of a <see cref="SourceTemplateAttribute">source template</see> if the
    /// <see cref="MacroAttribute"/> is applied on a template method.
    /// </summary>
    [CanBeNull] public string Target { get; set; }
After:
    /// Gets or sets identifies the target parameter of a <see cref="SourceTemplateAttribute">source template</see> if the
    /// <see cref="MacroAttribute"/> is applied on a template method.
    /// </summary>
    [CanBeNull]
        public string Target { get; set; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      CollectionAccessType = collectionAccessType;
After:
      this.CollectionAccessType = collectionAccessType;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      CollectionAccessType = collectionAccessType;
After:
      this.CollectionAccessType = collectionAccessType;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      CollectionAccessType = collectionAccessType;
After:
      this.CollectionAccessType = collectionAccessType;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      CollectionAccessType = collectionAccessType;
After:
      this.CollectionAccessType = collectionAccessType;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  /// Provides a value for the <see cref="CollectionAccessAttribute"/> to define
  /// how the collection method invocation affects the contents of the collection.
  /// </summary>
  [Flags]
  public enum CollectionAccessType
  {
    /// <summary>Method does not use or modify content of the collection.</summary>
    None = 0,
    /// <summary>Method only reads content of the collection but does not modify it.</summary>
    Read = 1,
    /// <summary>Method can change content of the collection but does not add new elements.</summary>
    ModifyExistingContent = 2,
    /// <summary>Method can add new elements to the collection.</summary>
    UpdatedContent = ModifyExistingContent | 4
  }

  /// <summary>
  /// Indicates that the marked method is assertion method, i.e. it halts the control flow if
After:
  /// Indicates that the marked method is assertion method, i.e. it halts the control flow if
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  /// Provides a value for the <see cref="CollectionAccessAttribute"/> to define
  /// how the collection method invocation affects the contents of the collection.
  /// </summary>
  [Flags]
  public enum CollectionAccessType
  {
    /// <summary>Method does not use or modify content of the collection.</summary>
    None = 0,
    /// <summary>Method only reads content of the collection but does not modify it.</summary>
    Read = 1,
    /// <summary>Method can change content of the collection but does not add new elements.</summary>
    ModifyExistingContent = 2,
    /// <summary>Method can add new elements to the collection.</summary>
    UpdatedContent = ModifyExistingContent | 4
  }

  /// <summary>
  /// Indicates that the marked method is assertion method, i.e. it halts the control flow if
After:
  /// Indicates that the marked method is assertion method, i.e. it halts the control flow if
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  /// Provides a value for the <see cref="CollectionAccessAttribute"/> to define
  /// how the collection method invocation affects the contents of the collection.
  /// </summary>
  [Flags]
  public enum CollectionAccessType
  {
    /// <summary>Method does not use or modify content of the collection.</summary>
    None = 0,
    /// <summary>Method only reads content of the collection but does not modify it.</summary>
    Read = 1,
    /// <summary>Method can change content of the collection but does not add new elements.</summary>
    ModifyExistingContent = 2,
    /// <summary>Method can add new elements to the collection.</summary>
    UpdatedContent = ModifyExistingContent | 4
  }

  /// <summary>
  /// Indicates that the marked method is assertion method, i.e. it halts the control flow if
After:
  /// Indicates that the marked method is assertion method, i.e. it halts the control flow if
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  /// Provides a value for the <see cref="CollectionAccessAttribute"/> to define
  /// how the collection method invocation affects the contents of the collection.
  /// </summary>
  [Flags]
  public enum CollectionAccessType
  {
    /// <summary>Method does not use or modify content of the collection.</summary>
    None = 0,
    /// <summary>Method only reads content of the collection but does not modify it.</summary>
    Read = 1,
    /// <summary>Method can change content of the collection but does not add new elements.</summary>
    ModifyExistingContent = 2,
    /// <summary>Method can add new elements to the collection.</summary>
    UpdatedContent = ModifyExistingContent | 4
  }

  /// <summary>
  /// Indicates that the marked method is assertion method, i.e. it halts the control flow if
After:
  /// Indicates that the marked method is assertion method, i.e. it halts the control flow if
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  public sealed class AssertionMethodAttribute : Attribute { }
After:
  public sealed class AssertionMethodAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  public sealed class AssertionMethodAttribute : Attribute { }
After:
  public sealed class AssertionMethodAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  public sealed class AssertionMethodAttribute : Attribute { }
After:
  public sealed class AssertionMethodAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  public sealed class AssertionMethodAttribute : Attribute { }
After:
  public sealed class AssertionMethodAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      ConditionType = conditionType;
After:
      this.ConditionType = conditionType;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      ConditionType = conditionType;
After:
      this.ConditionType = conditionType;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      ConditionType = conditionType;
After:
      this.ConditionType = conditionType;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      ConditionType = conditionType;
After:
      this.ConditionType = conditionType;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  /// Specifies assertion type. If the assertion method argument satisfies the condition,
  /// then the execution continues. Otherwise, execution is assumed to be halted.
  /// </summary>
  public enum AssertionConditionType
  {
    /// <summary>Marked parameter should be evaluated to true.</summary>
    IS_TRUE = 0,
    /// <summary>Marked parameter should be evaluated to false.</summary>
    IS_FALSE = 1,
    /// <summary>Marked parameter should be evaluated to null value.</summary>
    IS_NULL = 2,
    /// <summary>Marked parameter should be evaluated to not null value.</summary>
    IS_NOT_NULL = 3,
  }

  /// <summary>
  /// Indicates that the marked method unconditionally terminates control flow execution.
After:
  /// Indicates that the marked method unconditionally terminates control flow execution.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  /// Specifies assertion type. If the assertion method argument satisfies the condition,
  /// then the execution continues. Otherwise, execution is assumed to be halted.
  /// </summary>
  public enum AssertionConditionType
  {
    /// <summary>Marked parameter should be evaluated to true.</summary>
    IS_TRUE = 0,
    /// <summary>Marked parameter should be evaluated to false.</summary>
    IS_FALSE = 1,
    /// <summary>Marked parameter should be evaluated to null value.</summary>
    IS_NULL = 2,
    /// <summary>Marked parameter should be evaluated to not null value.</summary>
    IS_NOT_NULL = 3,
  }

  /// <summary>
  /// Indicates that the marked method unconditionally terminates control flow execution.
After:
  /// Indicates that the marked method unconditionally terminates control flow execution.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  /// Specifies assertion type. If the assertion method argument satisfies the condition,
  /// then the execution continues. Otherwise, execution is assumed to be halted.
  /// </summary>
  public enum AssertionConditionType
  {
    /// <summary>Marked parameter should be evaluated to true.</summary>
    IS_TRUE = 0,
    /// <summary>Marked parameter should be evaluated to false.</summary>
    IS_FALSE = 1,
    /// <summary>Marked parameter should be evaluated to null value.</summary>
    IS_NULL = 2,
    /// <summary>Marked parameter should be evaluated to not null value.</summary>
    IS_NOT_NULL = 3,
  }

  /// <summary>
  /// Indicates that the marked method unconditionally terminates control flow execution.
After:
  /// Indicates that the marked method unconditionally terminates control flow execution.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  /// Specifies assertion type. If the assertion method argument satisfies the condition,
  /// then the execution continues. Otherwise, execution is assumed to be halted.
  /// </summary>
  public enum AssertionConditionType
  {
    /// <summary>Marked parameter should be evaluated to true.</summary>
    IS_TRUE = 0,
    /// <summary>Marked parameter should be evaluated to false.</summary>
    IS_FALSE = 1,
    /// <summary>Marked parameter should be evaluated to null value.</summary>
    IS_NULL = 2,
    /// <summary>Marked parameter should be evaluated to not null value.</summary>
    IS_NOT_NULL = 3,
  }

  /// <summary>
  /// Indicates that the marked method unconditionally terminates control flow execution.
After:
  /// Indicates that the marked method unconditionally terminates control flow execution.
*/
  public enum CollectionAccessType
    {
        /// <summary>Method does not use or modify content of the collection.</summary>
        None = 0,

        /// <summary>Method only reads content of the collection but does not modify it.</summary>
        Read = 1,

        /// <summary>Method can change content of the collection but does not add new elements.</summary>
        ModifyExistingContent = 2,

        /// <summary>Method can add new elements to the collection.</summary>
        UpdatedContent = ModifyExistingContent | 4,
    }

    /// <summary>
    /// Specifies assertion type. If the assertion method argument satisfies the condition,
    /// then the execution continues. Otherwise, execution is assumed to be halted.
    /// </summary>
    public enum AssertionConditionType
    {
        /// <summary>Marked parameter should be evaluated to true.</summary>
        IS_TRUE = 0,

        /// <summary>Marked parameter should be evaluated to false.</summary>
        IS_FALSE = 1,

        /// <summary>Marked parameter should be evaluated to null value.</summary>
        IS_NULL = 2,

        /// <summary>Marked parameter should be evaluated to not null value.</summary>
        IS_NOT_NULL = 3,
  
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  public sealed class TerminatesProgramAttribute : Attribute { }

  /// <summary>
  /// Indicates that the method is a pure LINQ method, with postponed enumeration (like Enumerable.Select,
  /// .Where). This annotation allows inference of [InstantHandle] annotation for parameters
  /// of delegate type by analyzing LINQ method chains.
  /// </summary>
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class LinqTunnelAttribute : Attribute { }

  /// <summary>
  /// Indicates that IEnumerable passed as a parameter is not enumerated.
  /// Use this annotation to suppress the 'Possible multiple enumeration of IEnumerable' inspection.
  /// </summary>
  /// <example><code>
  /// static void ThrowIfNull&lt;T&gt;([NoEnumeration] T v, string n) where T : class
  /// {
  ///   // custom check for null but no enumeration
  /// }
  ///
  /// void Foo(IEnumerable&lt;string&gt; values)
  /// {
  ///   ThrowIfNull(values, nameof(values));
  ///   var x = values.ToList(); // No warnings about multiple enumeration
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class NoEnumerationAttribute : Attribute { }

  /// <summary>
  /// Indicates that the marked parameter, field, or property is a regular expression pattern.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class RegexPatternAttribute : Attribute { }

  /// <summary>
  /// Language of injected code fragment inside marked by <see cref="LanguageInjectionAttribute"/> string literal.
  /// </summary>
  public enum InjectedLanguage
After:
  public sealed class TerminatesProgramAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the method is a pure LINQ method, with postponed enumeration (like Enumerable.Select,
  /// .Where). This annotation allows inference of [InstantHandle] annotation for parameters
  /// of delegate type by analyzing LINQ method chains.
  /// </summary>
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class LinqTunnelAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that IEnumerable passed as a parameter is not enumerated.
  /// Use this annotation to suppress the 'Possible multiple enumeration of IEnumerable' inspection.
  /// </summary>
  /// <example><code>
  /// static void ThrowIfNull&lt;T&gt;([NoEnumeration] T v, string n) where T : class
  /// {
  ///   // custom check for null but no enumeration
  /// }
  ///
  /// void Foo(IEnumerable&lt;string&gt; values)
  /// {
  ///   ThrowIfNull(values, nameof(values));
  ///   var x = values.ToList(); // No warnings about multiple enumeration
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class NoEnumerationAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked parameter, field, or property is a regular expression pattern.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class RegexPatternAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked parameter, field, or property is accepting a string literal
  /// containing code fragment in a language specified by the <see cref="InjectedLanguage"/>.
  /// </summary>
  /// <example><code>
  /// void Foo([LanguageInjection(InjectedLanguage.CSS, Prefix = "body{", Suffix = "}")] string cssProps)
  /// {
  ///   // cssProps should only contains a list of CSS properties
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class LanguageInjectionAttribute : Attribute
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  public sealed class TerminatesProgramAttribute : Attribute { }

  /// <summary>
  /// Indicates that the method is a pure LINQ method, with postponed enumeration (like Enumerable.Select,
  /// .Where). This annotation allows inference of [InstantHandle] annotation for parameters
  /// of delegate type by analyzing LINQ method chains.
  /// </summary>
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class LinqTunnelAttribute : Attribute { }

  /// <summary>
  /// Indicates that IEnumerable passed as a parameter is not enumerated.
  /// Use this annotation to suppress the 'Possible multiple enumeration of IEnumerable' inspection.
  /// </summary>
  /// <example><code>
  /// static void ThrowIfNull&lt;T&gt;([NoEnumeration] T v, string n) where T : class
  /// {
  ///   // custom check for null but no enumeration
  /// }
  ///
  /// void Foo(IEnumerable&lt;string&gt; values)
  /// {
  ///   ThrowIfNull(values, nameof(values));
  ///   var x = values.ToList(); // No warnings about multiple enumeration
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class NoEnumerationAttribute : Attribute { }

  /// <summary>
  /// Indicates that the marked parameter, field, or property is a regular expression pattern.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class RegexPatternAttribute : Attribute { }

  /// <summary>
  /// Language of injected code fragment inside marked by <see cref="LanguageInjectionAttribute"/> string literal.
  /// </summary>
  public enum InjectedLanguage
After:
  public sealed class TerminatesProgramAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the method is a pure LINQ method, with postponed enumeration (like Enumerable.Select,
  /// .Where). This annotation allows inference of [InstantHandle] annotation for parameters
  /// of delegate type by analyzing LINQ method chains.
  /// </summary>
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class LinqTunnelAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that IEnumerable passed as a parameter is not enumerated.
  /// Use this annotation to suppress the 'Possible multiple enumeration of IEnumerable' inspection.
  /// </summary>
  /// <example><code>
  /// static void ThrowIfNull&lt;T&gt;([NoEnumeration] T v, string n) where T : class
  /// {
  ///   // custom check for null but no enumeration
  /// }
  ///
  /// void Foo(IEnumerable&lt;string&gt; values)
  /// {
  ///   ThrowIfNull(values, nameof(values));
  ///   var x = values.ToList(); // No warnings about multiple enumeration
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class NoEnumerationAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked parameter, field, or property is a regular expression pattern.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class RegexPatternAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked parameter, field, or property is accepting a string literal
  /// containing code fragment in a language specified by the <see cref="InjectedLanguage"/>.
  /// </summary>
  /// <example><code>
  /// void Foo([LanguageInjection(InjectedLanguage.CSS, Prefix = "body{", Suffix = "}")] string cssProps)
  /// {
  ///   // cssProps should only contains a list of CSS properties
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class LanguageInjectionAttribute : Attribute
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  public sealed class TerminatesProgramAttribute : Attribute { }

  /// <summary>
  /// Indicates that the method is a pure LINQ method, with postponed enumeration (like Enumerable.Select,
  /// .Where). This annotation allows inference of [InstantHandle] annotation for parameters
  /// of delegate type by analyzing LINQ method chains.
  /// </summary>
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class LinqTunnelAttribute : Attribute { }

  /// <summary>
  /// Indicates that IEnumerable passed as a parameter is not enumerated.
  /// Use this annotation to suppress the 'Possible multiple enumeration of IEnumerable' inspection.
  /// </summary>
  /// <example><code>
  /// static void ThrowIfNull&lt;T&gt;([NoEnumeration] T v, string n) where T : class
  /// {
  ///   // custom check for null but no enumeration
  /// }
  ///
  /// void Foo(IEnumerable&lt;string&gt; values)
  /// {
  ///   ThrowIfNull(values, nameof(values));
  ///   var x = values.ToList(); // No warnings about multiple enumeration
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class NoEnumerationAttribute : Attribute { }

  /// <summary>
  /// Indicates that the marked parameter, field, or property is a regular expression pattern.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class RegexPatternAttribute : Attribute { }

  /// <summary>
  /// Language of injected code fragment inside marked by <see cref="LanguageInjectionAttribute"/> string literal.
  /// </summary>
  public enum InjectedLanguage
After:
  public sealed class TerminatesProgramAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the method is a pure LINQ method, with postponed enumeration (like Enumerable.Select,
  /// .Where). This annotation allows inference of [InstantHandle] annotation for parameters
  /// of delegate type by analyzing LINQ method chains.
  /// </summary>
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class LinqTunnelAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that IEnumerable passed as a parameter is not enumerated.
  /// Use this annotation to suppress the 'Possible multiple enumeration of IEnumerable' inspection.
  /// </summary>
  /// <example><code>
  /// static void ThrowIfNull&lt;T&gt;([NoEnumeration] T v, string n) where T : class
  /// {
  ///   // custom check for null but no enumeration
  /// }
  ///
  /// void Foo(IEnumerable&lt;string&gt; values)
  /// {
  ///   ThrowIfNull(values, nameof(values));
  ///   var x = values.ToList(); // No warnings about multiple enumeration
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class NoEnumerationAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked parameter, field, or property is a regular expression pattern.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class RegexPatternAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked parameter, field, or property is accepting a string literal
  /// containing code fragment in a language specified by the <see cref="InjectedLanguage"/>.
  /// </summary>
  /// <example><code>
  /// void Foo([LanguageInjection(InjectedLanguage.CSS, Prefix = "body{", Suffix = "}")] string cssProps)
  /// {
  ///   // cssProps should only contains a list of CSS properties
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class LanguageInjectionAttribute : Attribute
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  public sealed class TerminatesProgramAttribute : Attribute { }

  /// <summary>
  /// Indicates that the method is a pure LINQ method, with postponed enumeration (like Enumerable.Select,
  /// .Where). This annotation allows inference of [InstantHandle] annotation for parameters
  /// of delegate type by analyzing LINQ method chains.
  /// </summary>
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class LinqTunnelAttribute : Attribute { }

  /// <summary>
  /// Indicates that IEnumerable passed as a parameter is not enumerated.
  /// Use this annotation to suppress the 'Possible multiple enumeration of IEnumerable' inspection.
  /// </summary>
  /// <example><code>
  /// static void ThrowIfNull&lt;T&gt;([NoEnumeration] T v, string n) where T : class
  /// {
  ///   // custom check for null but no enumeration
  /// }
  ///
  /// void Foo(IEnumerable&lt;string&gt; values)
  /// {
  ///   ThrowIfNull(values, nameof(values));
  ///   var x = values.ToList(); // No warnings about multiple enumeration
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class NoEnumerationAttribute : Attribute { }

  /// <summary>
  /// Indicates that the marked parameter, field, or property is a regular expression pattern.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class RegexPatternAttribute : Attribute { }

  /// <summary>
  /// Language of injected code fragment inside marked by <see cref="LanguageInjectionAttribute"/> string literal.
  /// </summary>
  public enum InjectedLanguage
After:
  public sealed class TerminatesProgramAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the method is a pure LINQ method, with postponed enumeration (like Enumerable.Select,
  /// .Where). This annotation allows inference of [InstantHandle] annotation for parameters
  /// of delegate type by analyzing LINQ method chains.
  /// </summary>
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class LinqTunnelAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that IEnumerable passed as a parameter is not enumerated.
  /// Use this annotation to suppress the 'Possible multiple enumeration of IEnumerable' inspection.
  /// </summary>
  /// <example><code>
  /// static void ThrowIfNull&lt;T&gt;([NoEnumeration] T v, string n) where T : class
  /// {
  ///   // custom check for null but no enumeration
  /// }
  ///
  /// void Foo(IEnumerable&lt;string&gt; values)
  /// {
  ///   ThrowIfNull(values, nameof(values));
  ///   var x = values.ToList(); // No warnings about multiple enumeration
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class NoEnumerationAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked parameter, field, or property is a regular expression pattern.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class RegexPatternAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked parameter, field, or property is accepting a string literal
  /// containing code fragment in a language specified by the <see cref="InjectedLanguage"/>.
  /// </summary>
  /// <example><code>
  /// void Foo([LanguageInjection(InjectedLanguage.CSS, Prefix = "body{", Suffix = "}")] string cssProps)
  /// {
  ///   // cssProps should only contains a list of CSS properties
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class LanguageInjectionAttribute : Attribute
*/
  }

    /// <summary>
    /// Language of injected code fragment inside marked by <see cref="LanguageInjectionAttribute"/> string literal.
    /// </summary>
    public enum InjectedLanguage
    {
    
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    CSS,
    HTML,
    JAVASCRIPT,
    JSON,
    XML
After:
    public LanguageInjectionAttribute(InjectedLanguage injectedLanguage)
    {
      this.InjectedLanguage = injectedLanguage;
    }

    /// <summary>Gets specify a language of injected code fragment.</summary>
    public InjectedLanguage InjectedLanguage { get; }

    /// <summary>Gets or sets specify a string that "precedes" injected string literal.</summary>
    [CanBeNull]
        public string Prefix { get; set; }

    /// <summary>Gets or sets specify a string that "follows" injected string literal.</summary>
    [CanBeNull]
        public string Suffix { get; set; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    CSS,
    HTML,
    JAVASCRIPT,
    JSON,
    XML
After:
    public LanguageInjectionAttribute(InjectedLanguage injectedLanguage)
    {
      this.InjectedLanguage = injectedLanguage;
    }

    /// <summary>Gets specify a language of injected code fragment.</summary>
    public InjectedLanguage InjectedLanguage { get; }

    /// <summary>Gets or sets specify a string that "precedes" injected string literal.</summary>
    [CanBeNull]
        public string Prefix { get; set; }

    /// <summary>Gets or sets specify a string that "follows" injected string literal.</summary>
    [CanBeNull]
        public string Suffix { get; set; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    CSS,
    HTML,
    JAVASCRIPT,
    JSON,
    XML
After:
    public LanguageInjectionAttribute(InjectedLanguage injectedLanguage)
    {
      this.InjectedLanguage = injectedLanguage;
    }

    /// <summary>Gets specify a language of injected code fragment.</summary>
    public InjectedLanguage InjectedLanguage { get; }

    /// <summary>Gets or sets specify a string that "precedes" injected string literal.</summary>
    [CanBeNull]
        public string Prefix { get; set; }

    /// <summary>Gets or sets specify a string that "follows" injected string literal.</summary>
    [CanBeNull]
        public string Suffix { get; set; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    CSS,
    HTML,
    JAVASCRIPT,
    JSON,
    XML
After:
    public LanguageInjectionAttribute(InjectedLanguage injectedLanguage)
    {
      this.InjectedLanguage = injectedLanguage;
    }

    /// <summary>Gets specify a language of injected code fragment.</summary>
    public InjectedLanguage InjectedLanguage { get; }

    /// <summary>Gets or sets specify a string that "precedes" injected string literal.</summary>
    [CanBeNull]
        public string Prefix { get; set; }

    /// <summary>Gets or sets specify a string that "follows" injected string literal.</summary>
    [CanBeNull]
        public string Suffix { get; set; }
*/
    CSS,
        HTML,
        JAVASCRIPT,
        JSON,
    
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  /// Indicates that the marked parameter, field, or property is accepting a string literal
  /// containing code fragment in a language specified by the <see cref="InjectedLanguage"/>.
  /// </summary>
  /// <example><code>
  /// void Foo([LanguageInjection(InjectedLanguage.CSS, Prefix = "body{", Suffix = "}")] string cssProps)
  /// {
  ///   // cssProps should only contains a list of CSS properties
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class LanguageInjectionAttribute : Attribute
  {
    public LanguageInjectionAttribute(InjectedLanguage injectedLanguage)
    {
      InjectedLanguage = injectedLanguage;
    }

    /// <summary>Specify a language of injected code fragment.</summary>
    public InjectedLanguage InjectedLanguage { get; }

    /// <summary>Specify a string that "precedes" injected string literal.</summary>
    [CanBeNull] public string Prefix { get; set; }

    /// <summary>Specify a string that "follows" injected string literal.</summary>
    [CanBeNull] public string Suffix { get; set; }
  }

  /// <summary>
  /// Prevents the Member Reordering feature from tossing members of the marked class.
After:
  /// Prevents the Member Reordering feature from tossing members of the marked class.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  /// Indicates that the marked parameter, field, or property is accepting a string literal
  /// containing code fragment in a language specified by the <see cref="InjectedLanguage"/>.
  /// </summary>
  /// <example><code>
  /// void Foo([LanguageInjection(InjectedLanguage.CSS, Prefix = "body{", Suffix = "}")] string cssProps)
  /// {
  ///   // cssProps should only contains a list of CSS properties
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class LanguageInjectionAttribute : Attribute
  {
    public LanguageInjectionAttribute(InjectedLanguage injectedLanguage)
    {
      InjectedLanguage = injectedLanguage;
    }

    /// <summary>Specify a language of injected code fragment.</summary>
    public InjectedLanguage InjectedLanguage { get; }

    /// <summary>Specify a string that "precedes" injected string literal.</summary>
    [CanBeNull] public string Prefix { get; set; }

    /// <summary>Specify a string that "follows" injected string literal.</summary>
    [CanBeNull] public string Suffix { get; set; }
  }

  /// <summary>
  /// Prevents the Member Reordering feature from tossing members of the marked class.
After:
  /// Prevents the Member Reordering feature from tossing members of the marked class.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  /// Indicates that the marked parameter, field, or property is accepting a string literal
  /// containing code fragment in a language specified by the <see cref="InjectedLanguage"/>.
  /// </summary>
  /// <example><code>
  /// void Foo([LanguageInjection(InjectedLanguage.CSS, Prefix = "body{", Suffix = "}")] string cssProps)
  /// {
  ///   // cssProps should only contains a list of CSS properties
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class LanguageInjectionAttribute : Attribute
  {
    public LanguageInjectionAttribute(InjectedLanguage injectedLanguage)
    {
      InjectedLanguage = injectedLanguage;
    }

    /// <summary>Specify a language of injected code fragment.</summary>
    public InjectedLanguage InjectedLanguage { get; }

    /// <summary>Specify a string that "precedes" injected string literal.</summary>
    [CanBeNull] public string Prefix { get; set; }

    /// <summary>Specify a string that "follows" injected string literal.</summary>
    [CanBeNull] public string Suffix { get; set; }
  }

  /// <summary>
  /// Prevents the Member Reordering feature from tossing members of the marked class.
After:
  /// Prevents the Member Reordering feature from tossing members of the marked class.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  /// Indicates that the marked parameter, field, or property is accepting a string literal
  /// containing code fragment in a language specified by the <see cref="InjectedLanguage"/>.
  /// </summary>
  /// <example><code>
  /// void Foo([LanguageInjection(InjectedLanguage.CSS, Prefix = "body{", Suffix = "}")] string cssProps)
  /// {
  ///   // cssProps should only contains a list of CSS properties
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class LanguageInjectionAttribute : Attribute
  {
    public LanguageInjectionAttribute(InjectedLanguage injectedLanguage)
    {
      InjectedLanguage = injectedLanguage;
    }

    /// <summary>Specify a language of injected code fragment.</summary>
    public InjectedLanguage InjectedLanguage { get; }

    /// <summary>Specify a string that "precedes" injected string literal.</summary>
    [CanBeNull] public string Prefix { get; set; }

    /// <summary>Specify a string that "follows" injected string literal.</summary>
    [CanBeNull] public string Suffix { get; set; }
  }

  /// <summary>
  /// Prevents the Member Reordering feature from tossing members of the marked class.
After:
  /// Prevents the Member Reordering feature from tossing members of the marked class.
*/
    XML,
    }

    /// <summary>
    /// This attribute is intended to mark publicly available API,
    /// which should not be removed and so is treated as used.
    /// </summary>
    [MeansImplicitUse(ImplicitUseTargetFlags.
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  public sealed class NoReorderAttribute : Attribute { }
After:
  public sealed class NoReorderAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  public sealed class NoReorderAttribute : Attribute { }
After:
  public sealed class NoReorderAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  public sealed class NoReorderAttribute : Attribute { }
After:
  public sealed class NoReorderAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  public sealed class NoReorderAttribute : Attribute { }
After:
  public sealed class NoReorderAttribute : Attribute
    {
    }
*/
WithMembers)]
    [AttributeUsage(AttributeTargets.All, Inherited = false)]
    public sealed class PublicAPIAttribute : Attribute
    {
        public PublicAPIAttribute()
        {
        }

        public PublicAPIAttribute([NotNull] string comment)
        {
            this.Comment = comment;
        }

        [CanBeNull]
        public string Comment { get; }
    }

    /// <summary>
    /// Tells the code analysis engine if the parameter is completely handled when the invoked method is on stack.
    /// If the parameter is a delegate, indicates that delegate can only be invoked during method execution
    /// (the delegate can be invoked zero or multiple times, but not stored to some field and invoked later,
    /// when the containing method is no longer on the execution stack).
    /// If the parameter is an enumerable, indicates that it is enumerated while the method is executed.
    /// If <see cref="RequireAwait"/> is true, the attribute will only takes effect if the method invocation is located under the 'await' expression.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class InstantHandleAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets a value indicating whether require the method invocation to be used under the 'await' expression for this attribute to take effect on code analysis engine.
        /// Can be used for delegate/enumerable parameters of 'async' methods.
        /// </summary>
        public bool RequireAwait { get; set; }
    }

    /// <summary>
    /// Indicates that a method does not make any observable state changes.
    /// The same as <c>System.Diagnostics.Contracts.PureAttribute</c>.
    /// </summary>
    /// <example><code>
    /// [Pure] int Multiply(int x, int y) => x * y;
    ///
    /// void M() {
    ///   Multiply(123, 42); // Warning: Return value of pure method is not used
    /// }
    /// </code></example>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class PureAttribute : Attribute
    {
    }

    /// <summary>
    /// Indicates that the return value of the method invocation must be used.
    /// </summary>
    /// <remarks>
    /// Methods decorated with this attribute (in contrast to pure methods) might change state,
    /// but make no sense without using their return value. <br/>
    /// Similarly to <see cref="PureAttribute"/>, this attribute
    /// will help to detect usages of the method when the return value is not used.
    /// Optionally, you can specify a message to use when showing warnings, e.g.
    /// <code>[MustUseReturnValue("Use the return value to...")]</code>.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class MustUseReturnValueAttribute : Attribute
    {
        public MustUseReturnValueAttribute()
        {
        }

        public MustUseReturnValueAttribute([NotNull] string justification)
        {
            this.Justification = justification;
        }

        [CanBeNull]
        public string Justification { get; }
    }

    /// <summary>
    /// This annotation allows to enforce allocation-less usage patterns of delegates for performance-critical APIs.
    /// When this annotation is applied to the parameter of delegate type, IDE checks the input argument of this parameter:
    /// * When lambda expression or anonymous method is passed as an argument, IDE verifies that the passed closure
    ///   has no captures of the containing local variables and the compiler is able to cache the delegate instance
    ///   to avoid heap allocations. Otherwise the warning is produced.
    /// * IDE warns when method name or local function name is passed as an argument as this always results
    ///   in heap allocation of the delegate instance.
    /// </summary>
    /// <remarks>
    /// In C# 9.0 code IDE would also suggest to annotate the anonymous function with 'static' modifier
    /// to make use of the similar analysis provided by the language/compiler.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class RequireStaticDelegateAttribute : Attribute
    {
        public bool IsError { get; set; }
    }

    /// <summary>
    /// Indicates the type member or parameter of some type, that should be used instead of all other ways
    /// to get the value of that type. This annotation is useful when you have some "context" value evaluated
    /// and stored somewhere, meaning that all other ways to get this value must be consolidated with existing one.
    /// </summary>
    /// <example><code>
    /// class Foo {
    ///   [ProvidesContext] IBarService _barService = ...;
    ///
    ///   void ProcessNode(INode node) {
    ///     DoSomething(node, node.GetGlobalServices().Bar);
    ///     //              ^ Warning: use value of '_barService' field
    ///   }
    /// }
    /// </code></example>
    [AttributeUsage(
      AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Parameter | AttributeTargets.Method |
      AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Struct | AttributeTargets.GenericParameter)]
    public sealed class ProvidesContextAttribute : Attribute
    {
    }

    /// <summary>
    /// Indicates that a parameter is a path to a file or a folder within a web project.
    /// Path can be relative or absolute, starting from web root (~).
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class PathReferenceAttribute : Attribute
    {
        public PathReferenceAttribute()
        {
        }

        public PathReferenceAttribute([NotNull, PathReference] string basePath)
        {
            this.BasePath = basePath;
        }

        [CanBeNull]
        public string BasePath { get; }
    }

    /// <summary>
    /// An extension method marked with this attribute is processed by code completion
    /// as a 'Source Template'. When the extension method is completed over some expression, its source code
    /// is automatically expanded like a template at call site.
    /// </summary>
    /// <remarks>
    /// Template method body can contain valid source code and/or special comments starting with '$'.
    /// Text inside these comments is added as source code when the template is applied. Template parameters
    /// can be used either as additional method parameters or as identifiers wrapped in two '$' signs.
    /// Use the <see cref="MacroAttribute"/> attribute to specify macros for parameters.
    /// </remarks>
    /// <example>
    /// In this example, the 'forEach' method is a source template available over all values
    /// of enumerable types, producing ordinary C# 'foreach' statement and placing caret inside block:
    /// <code>
    /// [SourceTemplate]
    /// public static void forEach&lt;T&gt;(this IEnumerable&lt;T&gt; xs) {
    ///   foreach (var x in xs) {
    ///      //$ $END$
    ///   }
    /// }
    /// </code>
    /// </example>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class SourceTemplateAttribute : Attribute
    {
    }

    /// <summary>
    /// Allows specifying a macro for a parameter of a <see cref="SourceTemplateAttribute">source template</see>.
    /// </summary>
    /// <remarks>
    /// You can apply the attribute on the whole method or on any of its additional parameters. The macro expression
    /// is defined in the <see cref="MacroAttribute.Expression"/> property. When applied on a method, the target
    /// template parameter is defined in the <see cref="MacroAttribute.Target"/> property. To apply the macro silently
    /// for the parameter, set the <see cref="MacroAttribute.Editable"/> property value = -1.
    /// </remarks>
    /// <example>
    /// Applying the attribute on a source template method:
    /// <code>
    /// [SourceTemplate, Macro(Target = "item", Expression = "suggestVariableName()")]
    /// public static void forEach&lt;T&gt;(this IEnumerable&lt;T&gt; collection) {
    ///   foreach (var item in collection) {
    ///     //$ $END$
    ///   }
    /// }
    /// </code>
    /// Applying the attribute on a template method parameter:
    /// <code>
    /// [SourceTemplate]
    /// public static void something(this Entity x, [Macro(Expression = "guid()", Editable = -1)] string newguid) {
    ///   /*$ var $x$Id = "$newguid$" + x.ToString();
    ///   x.DoSomething($x$Id); */
    /// }
    /// </code>
    /// </example>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method, AllowMultiple = true)]
    public sealed class MacroAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets allows specifying a macro that will be executed for a <see cref="SourceTemplateAttribute">source template</see>
        /// parameter when the template is expanded.
        /// </summary>
        [CanBeNull]
        public string Expression { get; set; }

        /// <summary>
        /// Gets or sets allows specifying which occurrence of the target parameter becomes editable when the template is deployed.
        /// </summary>
        /// <remarks>
        /// If the target parameter is used several times in the template, only one occurrence becomes editable;
        /// other occurrences are changed synchronously. To specify the zero-based index of the editable occurrence,
        /// use values >= 0. To make the parameter non-editable when the template is expanded, use -1.
        /// </remarks>
        public int Editable { get; set; }

        /// <summary>
        /// Gets or sets identifies the target parameter of a <see cref="SourceTemplateAttribute">source template</see> if the
        /// <see cref="MacroAttribute"/> is applied on a template method.
        /// </summary>
        [CanBeNull]
        public string Target { get; set; }
    }

    /// <summary>
    /// Indicates how method, constructor invocation, or property access
    /// over collection type affects the contents of the collection.
    /// When applied to a return value of a method indicates if the returned collection
    /// is created exclusively for the caller (CollectionAccessType.UpdatedContent) or
    /// can be read/updated from outside (CollectionAccessType.Read | CollectionAccessType.UpdatedContent)
    /// Use <see cref="CollectionAccessType"/> to specify the access type.
    /// </summary>
    /// <remarks>
    /// Using this attribute only makes sense if all collection methods are marked with this attribute.
    /// </remarks>
    /// <example><code>
    /// public class MyStringCollection : List&lt;string&gt;
    /// {
    ///   [CollectionAccess(CollectionAccessType.Read)]
    ///   public string GetFirstString()
    ///   {
    ///     return this.ElementAt(0);
    ///   }
    /// }
    /// class Test
    /// {
    ///   public void Foo()
    ///   {
    ///     // Warning: Contents of the collection is never updated
    ///     var col = new MyStringCollection();
    ///     string x = col.GetFirstString();
    ///   }
    /// }
    /// </code></example>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Property | AttributeTargets.ReturnValue)]
    public sealed class CollectionAccessAttribute : Attribute
    {
        public CollectionAccessAttribute(CollectionAccessType collectionAccessType)
        {
            this.CollectionAccessType = collectionAccessType;
        }

        public CollectionAccessType CollectionAccessType { get; }
    }

    /// <summary>
    /// Indicates that the marked method is assertion method, i.e. it halts the control flow if
    /// one of the conditions is satisfied. To set the condition, mark one of the parameters with
    /// <see cref="AssertionConditionAttribute"/> attribute.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class AssertionMethodAttribute : Attribute
    {
    }

    /// <summary>
    /// Indicates the condition parameter of the assertion method. The method itself should be
    /// marked by <see cref="AssertionMethodAttribute"/> attribute. The mandatory argument of
    /// the attribute is the assertion type.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class AssertionConditionAttribute : Attribute
    {
        public AssertionConditionAttribute(AssertionConditionType conditionType)
        {
            this.ConditionType = conditionType;
        }

        public AssertionConditionType ConditionType { get; }
    }

    /// <summary>
    /// Indicates that the marked method unconditionally terminates control flow execution.
    /// For example, it could unconditionally throw exception.
    /// </summary>
    [Obsolete("Use [ContractAnnotation('=> halt')] instead")]
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class TerminatesProgramAttribute : Attribute
    {
    }

    /// <summary>
    /// Indicates that the method is a pure LINQ method, with postponed enumeration (like Enumerable.Select,
    /// .Where). This annotation allows inference of [InstantHandle] annotation for parameters
    /// of delegate type by analyzing LINQ method chains.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class LinqTunnelAttribute : Attribute
    {
    }

    /// <summary>
    /// Indicates that IEnumerable passed as a parameter is not enumerated.
    /// Use this annotation to suppress the 'Possible multiple enumeration of IEnumerable' inspection.
    /// </summary>
    /// <example><code>
    /// static void ThrowIfNull&lt;T&gt;([NoEnumeration] T v, string n) where T : class
    /// {
    ///   // custom check for null but no enumeration
    /// }
    ///
    /// void Foo(IEnumerable&lt;string&gt; values)
    /// {
    ///   ThrowIfNull(values, nameof(values));
    ///   var x = values.ToList(); // No warnings about multiple enumeration
    /// }
    /// </code></example>
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class NoEnumerationAttribute : Attribute
    {
    }

    /// <summary>
    /// Indicates that the marked parameter, field, or property is a regular expression pattern.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class RegexPatternAttribute : Attribute
    {
    }

    /// <summary>
    /// Indicates that the marked parameter, field, or property is accepting a string literal
    /// containing code fragment in a language specified by the <see cref="InjectedLanguage"/>.
    /// </summary>
    /// <example><code>
    /// void Foo([LanguageInjection(InjectedLanguage.CSS, Prefix = "body{", Suffix = "}")] string cssProps)
    /// {
    ///   // cssProps should only contains a list of CSS properties
    /// }
    /// </code></example>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class LanguageInjectionAttribute : Attribute
    {
        public LanguageInjectionAttribute(InjectedLanguage injectedLanguage)
        {
            this.InjectedLanguage = injectedLanguage;
        }

        /// <summary>Gets specify a language of injected code fragment.</summary>
        public InjectedLanguage InjectedLanguage { get; }

        /// <summary>Gets or sets specify a string that "precedes" injected string literal.</summary>
        [CanBeNull]
        public string Prefix { get; set; }

        /// <summary>Gets or sets specify a string that "follows" injected string literal.</summary>
        [CanBeNull]
        public string Suffix { get; set; }
    }

    /// <summary>
    /// Prevents the Member Reordering feature from tossing members of the marked class.
    /// </summary>
    /// <remarks>
    /// The attribute must be mentioned in your member reordering patterns.
    /// </remarks>
    [AttributeUsage(
      AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Struct | AttributeTargets.Enum)]
    public sealed class NoReorderAttribute : Attribute
    {
    }

    /// <summary>
    /// <para>
    /// Defines the code search template using the Structural Search and Replace syntax.
    /// It allows you to find and, if necessary, replace blocks of code that match a specific pattern.
    /// Search and replace patterns consist of a textual part and placeholders.
    /// Textural part must contain only identifiers allowed in the target language and will be matched exactly (white spaces, tabulation characters, and line breaks are ignored).
    /// Placeholders allow matching variable parts of the target code blocks.
    /// A placeholder has the following format: $placeholder_name$- where placeholder_name is an arbitrary identifier.
    /// </para>
    /// <para>
    /// Available placeholders:
    /// <list type="bullet">
    /// <item>$this$ - expression of containing type</item>
    /// <item>$thisType$ - containing type</item>
    /// <item>$member$ - current member placeholder</item>
    /// <item>$qualifier$ - this placeholder is available in the replace pattern and can be used to insert qualifier expression matched by the $member$ placeholder.
    /// (Note that if $qualifier$ placeholder is used, then $member$ placeholder will match only qualified references)</item>
    /// <item>$expression$ - expression of any type</item>
    /// <item>$identifier$ - identifier placeholder</item>
    /// <item>$args$ - any number of arguments</item>
    /// <item>$arg$ - single argument</item>
    /// <item>$arg1$ ... $arg10$ - single argument</item>
    /// <item>$stmts$ - any number of statements</item>
    /// <item>$stmt$ - single statement</item>
    /// <item>$stmt1$ ... $stmt10$ - single statement</item>
    /// <item>$name{Expression, 'Namespace.FooType'}$ - expression with 'Namespace.FooType' type</item>
    /// <item>$expression{'Namespace.FooType'}$ - expression with 'Namespace.FooType' type</item>
    /// <item>$name{Type, 'Namespace.FooType'}$ - 'Namespace.FooType' type</item>
    /// <item>$type{'Namespace.FooType'}$ - 'Namespace.FooType' type</item>
    /// <item>$statement{1,2}$ - 1 or 2 statements</item>
    /// </list>
    /// </para>
    /// <para>
    /// Note that you can also define your own placeholders of the supported types and specify arguments for each placeholder type.
    /// This can be done using the following format: $name{type, arguments}$. Where 'name' - is the name of your placeholder,
    /// 'type' - is the type of your placeholder (one of the following: Expression, Type, Identifier, Statement, Argument, Member),
    /// 'arguments' - arguments list for your placeholder. Each placeholder type supports it's own arguments, check examples below for mode details.
    /// Placeholder type may be omitted and determined from the placeholder name, if name has one of the following prefixes:
    /// <list type="bullet">
    /// <item>expr, expression - expression placeholder, e.g. $exprPlaceholder{}$, $expressionFoo{}$</item>
    /// <item>arg, argument - argument placeholder, e.g. $argPlaceholder{}$, $argumentFoo{}$</item>
    /// <item>ident, identifier - identifier placeholder, e.g. $identPlaceholder{}$, $identifierFoo{}$</item>
    /// <item>stmt, statement - statement placeholder, e.g. $stmtPlaceholder{}$, $statementFoo{}$</item>
    /// <item>type - type placeholder, e.g. $typePlaceholder{}$, $typeFoo{}$</item>
    /// <item>member - member placeholder, e.g. $memberPlaceholder{}$, $memberFoo{}$</item>
    /// </list>
    /// </para>
    /// <para>
    /// Expression placeholder arguments:
    /// <list type="bullet">
    /// <item>expressionType - string value in single quotes, specifies full type name to match (empty string by default)</item>
    /// <item>exactType - boolean value, specifies if expression should have exact type match (false by default)</item>
    /// </list>
    /// Examples:
    /// <list type="bullet">
    /// <item>$myExpr{Expression, 'Namespace.FooType', true}$ - defines expression placeholder, matching expressions of the 'Namespace.FooType' type with exact matching.</item>
    /// <item>$myExpr{Expression, 'Namespace.FooType'}$ - defines expression placeholder, matching expressions of the 'Namespace.FooType' type or expressions which can be implicitly converted to 'Namespace.FooType'.</item>
    /// <item>$myExpr{Expression}$ - defines expression placeholder, matching expressions of any type.</item>
    /// <item>$exprFoo{'Namespace.FooType', true}$ - defines expression placeholder, matching expressions of the 'Namespace.FooType' type with exact matching.</item>
    /// </list>
    /// </para>
    /// <para>
    /// Type placeholder arguments:
    /// <list type="bullet">
    /// <item>type - string value in single quotes, specifies full type name to match (empty string by default)</item>
    /// <item>exactType - boolean value, specifies if expression should have exact type match (false by default)</item>
    /// </list>
    /// Examples:
    /// <list type="bullet">
    /// <item>$myType{Type, 'Namespace.FooType', true}$ - defines type placeholder, matching 'Namespace.FooType' types with exact matching.</item>
    /// <item>$myType{Type, 'Namespace.FooType'}$ - defines type placeholder, matching 'Namespace.FooType' types or types, which can be implicitly converted to 'Namespace.FooType'.</item>
    /// <item>$myType{Type}$ - defines type placeholder, matching any type.</item>
    /// <item>$typeFoo{'Namespace.FooType', true}$ - defines types placeholder, matching 'Namespace.FooType' types with exact matching.</item>
    /// </list>
    /// </para>
    /// <para>
    /// Identifier placeholder arguments:
    /// <list type="bullet">
    /// <item>nameRegex - string value in single quotes, specifies regex to use for matching (empty string by default)</item>
    /// <item>nameRegexCaseSensitive - boolean value, specifies if name regex is case sensitive (true by default)</item>
    /// <item>type - string value in single quotes, specifies full type name to match (empty string by default)</item>
    /// <item>exactType - boolean value, specifies if expression should have exact type match (false by default)</item>
    /// </list>
    /// Examples:
    /// <list type="bullet">
    /// <item>$myIdentifier{Identifier, 'my.*', false, 'Namespace.FooType', true}$ - defines identifier placeholder, matching identifiers (ignoring case) starting with 'my' prefix with 'Namespace.FooType' type.</item>
    /// <item>$myIdentifier{Identifier, 'my.*', true, 'Namespace.FooType', true}$ - defines identifier placeholder, matching identifiers (case sensitively) starting with 'my' prefix with 'Namespace.FooType' type.</item>
    /// <item>$identFoo{'my.*'}$ - defines identifier placeholder, matching identifiers (case sensitively) starting with 'my' prefix.</item>
    /// </list>
    /// </para>
    /// <para>
    /// Statement placeholder arguments:
    /// <list type="bullet">
    /// <item>minimalOccurrences - minimal number of statements to match (-1 by default)</item>
    /// <item>maximalOccurrences - maximal number of statements to match (-1 by default)</item>
    /// </list>
    /// Examples:
    /// <list type="bullet">
    /// <item>$myStmt{Statement, 1, 2}$ - defines statement placeholder, matching 1 or 2 statements.</item>
    /// <item>$myStmt{Statement}$ - defines statement placeholder, matching any number of statements.</item>
    /// <item>$stmtFoo{1, 2}$ - defines statement placeholder, matching 1 or 2 statements.</item>
    /// </list>
    /// </para>
    /// <para>
    /// Argument placeholder arguments:
    /// <list type="bullet">
    /// <item>minimalOccurrences - minimal number of arguments to match (-1 by default)</item>
    /// <item>maximalOccurrences - maximal number of arguments to match (-1 by default)</item>
    /// </list>
    /// Examples:
    /// <list type="bullet">
    /// <item>$myArg{Argument, 1, 2}$ - defines argument placeholder, matching 1 or 2 arguments.</item>
    /// <item>$myArg{Argument}$ - defines argument placeholder, matching any number of arguments.</item>
    /// <item>$argFoo{1, 2}$ - defines argument placeholder, matching 1 or 2 arguments.</item>
    /// </list>
    /// </para>
    /// <para>
    /// Member placeholder arguments:
    /// <list type="bullet">
    /// <item>docId - string value in single quotes, specifies XML documentation id of the member to match (empty by default)</item>
    /// </list>
    /// Examples:
    /// <list type="bullet">
    /// <item>$myMember{Member, 'M:System.String.IsNullOrEmpty(System.String)'}$ - defines member placeholder, matching 'IsNullOrEmpty' member of the 'System.String' type.</item>
    /// <item>$memberFoo{'M:System.String.IsNullOrEmpty(System.String)'}$ - defines member placeholder, matching 'IsNullOrEmpty' member of the 'System.String' type.</item>
    /// </list>
    /// </para>
    /// <para>
    /// For more information please refer to the <a href="https://www.jetbrains.com/help/resharper/Navigation_and_Search__Structural_Search_and_Replace.html">Structural Search and Replace</a> article.
    /// </para>
    /// </summary>
    [AttributeUsage(
      AttributeTargets.Method
      | AttributeTargets.Constructor
      | AttributeTargets.Property
      | AttributeTargets.Field
      | AttributeTargets.Event
      | AttributeTargets.Interface
      | AttributeTargets.Class
      | AttributeTargets.Struct
      | AttributeTargets.Enum,
      AllowMultiple = true,
      Inherited = false)]
    public sealed class CodeTemplateAttribute : Attribute
    {
        public CodeTemplateAttribute(string searchTemplate)
    
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      SearchTemplate = searchTemplate;
After:
      this.SearchTemplate = searchTemplate;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      SearchTemplate = searchTemplate;
After:
      this.SearchTemplate = searchTemplate;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      SearchTemplate = searchTemplate;
After:
      this.SearchTemplate = searchTemplate;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      SearchTemplate = searchTemplate;
After:
      this.SearchTemplate = searchTemplate;
*/
    {
            this.SearchTemplate = searchTemplate;
    
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    /// Structural search pattern to use in the code template.
After:
    /// Gets structural search pattern to use in the code template.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    /// Structural search pattern to use in the code template.
After:
    /// Gets structural search pattern to use in the code template.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    /// Structural search pattern to use in the code template.
After:
    /// Gets structural search pattern to use in the code template.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    /// Structural search pattern to use in the code template.
After:
    /// Gets structural search pattern to use in the code template.
*/
    }

        /// <summary>
        /// Gets structural search pattern to use in the code template.
        /// Pattern includes textual part, which must contain only identifiers allowed in the target language,
        /// and placeholders, which allow matching variable parts of the target code blocks.
        /// </summary>
        public string SearchTemplate { get; }

    
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    /// Message to show when the search pattern was found.
After:
    /// Gets or sets message to show when the search pattern was found.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    /// Message to show when the search pattern was found.
After:
    /// Gets or sets message to show when the search pattern was found.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    /// Message to show when the search pattern was found.
After:
    /// Gets or sets message to show when the search pattern was found.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    /// Message to show when the search pattern was found.
After:
    /// Gets or sets message to show when the search pattern was found.
*/
    /// <summary>
        /// Gets or sets message to show when the search pattern was found.
        /// You can also prepend the message text with "Error:", "Warning:", "Suggestion:" or "Hint:" prefix to specify the pattern severity.
        /// Code patterns with replace template produce suggestions by default.
        /// However, if replace template is not provided, then warning severity will be used.
        /// </summary>
        public string Message { get; set; }

    
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    /// Structural search replace pattern to use in code template replacement.
After:
    /// Gets or sets structural search replace pattern to use in code template replacement.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    /// Structural search replace pattern to use in code template replacement.
After:
    /// Gets or sets structural search replace pattern to use in code template replacement.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    /// Structural search replace pattern to use in code template replacement.
After:
    /// Gets or sets structural search replace pattern to use in code template replacement.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    /// Structural search replace pattern to use in code template replacement.
After:
    /// Gets or sets structural search replace pattern to use in code template replacement.
*/
    /// <summary>
        /// Gets or sets structural search replace pattern to use in code template replacement.
        /// </summary>
        public string ReplaceTemplate { get; set; }

    
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    /// Replace message to show in the light bulb.
After:
    /// Gets or sets replace message to show in the light bulb.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    /// Replace message to show in the light bulb.
After:
    /// Gets or sets replace message to show in the light bulb.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    /// Replace message to show in the light bulb.
After:
    /// Gets or sets replace message to show in the light bulb.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    /// Replace message to show in the light bulb.
After:
    /// Gets or sets replace message to show in the light bulb.
*/
    /// <summary>
        /// Gets or sets replace message to show in the light bulb.
        /// </summary>
        public string ReplaceMessage { get; set; }

    
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    /// Apply code formatting after code replacement.
After:
    /// Gets or sets a value indicating whether apply code formatting after code replacement.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    /// Apply code formatting after code replacement.
After:
    /// Gets or sets a value indicating whether apply code formatting after code replacement.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    /// Apply code formatting after code replacement.
After:
    /// Gets or sets a value indicating whether apply code formatting after code replacement.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    /// Apply code formatting after code replacement.
After:
    /// Gets or sets a value indicating whether apply code formatting after code replacement.
*/
    /// <summary>
        /// Gets or sets a value indicating whether apply code formatting after code replacement.
        /// </summary>
        public bool FormatAfterReplace { get; set; } = true;

    
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    /// Whether similar code blocks should be matched.
After:
    /// Gets or sets a value indicating whether whether similar code blocks should be matched.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    /// Whether similar code blocks should be matched.
After:
    /// Gets or sets a value indicating whether whether similar code blocks should be matched.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    /// Whether similar code blocks should be matched.
After:
    /// Gets or sets a value indicating whether whether similar code blocks should be matched.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    /// Whether similar code blocks should be matched.
After:
    /// Gets or sets a value indicating whether whether similar code blocks should be matched.
*/
    /// <summary>
        /// Gets or sets a value indicating whether whether similar code blocks should be matched.
        /// </summary>
        public bool MatchSimilarConstructs { get; set; }

    
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    /// Automatically insert namespace import directives or remove qualifiers that become redundant after the template is applied.
After:
    /// Gets or sets a value indicating whether automatically insert namespace import directives or remove qualifiers that become redundant after the template is applied.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    /// Automatically insert namespace import directives or remove qualifiers that become redundant after the template is applied.
After:
    /// Gets or sets a value indicating whether automatically insert namespace import directives or remove qualifiers that become redundant after the template is applied.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    /// Automatically insert namespace import directives or remove qualifiers that become redundant after the template is applied.
After:
    /// Gets or sets a value indicating whether automatically insert namespace import directives or remove qualifiers that become redundant after the template is applied.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    /// Automatically insert namespace import directives or remove qualifiers that become redundant after the template is applied.
After:
    /// Gets or sets a value indicating whether automatically insert namespace import directives or remove qualifiers that become redundant after the template is applied.
*/
    /// <summary>
        /// Gets or sets a value indicating whether automatically insert namespace import directives or remove qualifiers that become redundant after the template is applied.
        /// </summary>
        public bool ShortenReferences { get; set; }

    
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    /// String to use as a suppression key.
After:
    /// Gets or sets string to use as a suppression key.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    /// String to use as a suppression key.
After:
    /// Gets or sets string to use as a suppression key.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    /// String to use as a suppression key.
After:
    /// Gets or sets string to use as a suppression key.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    /// String to use as a suppression key.
After:
    /// Gets or sets string to use as a suppression key.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  #region ASP.NET

  [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
After:
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  #region ASP.NET

  [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
After:
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  #region ASP.NET

  [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
After:
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  #region ASP.NET

  [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
After:
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
*/
    /// <summary>
        /// Gets or sets string to use as a suppression key.
        /// By default the following suppression key is used 'CodeTemplate_SomeType_SomeMember',
        /// where 'SomeType' and 'SomeMember' are names of the associated containing type and member to which this attribute is applied.
        /// </summary>
        public string SuppressionKey { get; set; }
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
  
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      TagName = tagName;
      ControlType = controlType;
After:
      this.TagName = tagName;
      this.ControlType = controlType;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      TagName = tagName;
      ControlType = controlType;
After:
      this.TagName = tagName;
      this.ControlType = controlType;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      TagName = tagName;
      ControlType = controlType;
After:
      this.TagName = tagName;
      this.ControlType = controlType;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      TagName = tagName;
      ControlType = controlType;
After:
      this.TagName = tagName;
      this.ControlType = controlType;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    [NotNull] public string TagName { get; }
After:
    [NotNull]
        public string TagName { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    [NotNull] public string TagName { get; }
After:
    [NotNull]
        public string TagName { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    [NotNull] public string TagName { get; }
After:
    [NotNull]
        public string TagName { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    [NotNull] public string TagName { get; }
After:
    [NotNull]
        public string TagName { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    [NotNull] public Type ControlType { get; }
After:
    [NotNull]
        public Type ControlType { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    [NotNull] public Type ControlType { get; }
After:
    [NotNull]
        public Type ControlType { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    [NotNull] public Type ControlType { get; }
After:
    [NotNull]
        public Type ControlType { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    [NotNull] public Type ControlType { get; }
After:
    [NotNull]
        public Type ControlType { get; }
*/
  public sealed class AspChildControlTypeAttribute : Attribute
    {
        public AspChildControlTypeAttribute([NotNull] string tagName, [NotNull] Type controlType)
        {
            this.TagName = tagName;
            this.ControlType = controlType;
        }

        [NotNull]
        public string TagName { get; }

        [NotNull]
        public Type ControlType { get; }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method)]

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  public sealed class AspDataFieldAttribute : Attribute { }

  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method)]
  public sealed class AspDataFieldsAttribute : Attribute { }

  [AttributeUsage(AttributeTargets.Property)]
  public sealed class AspMethodPropertyAttribute : Attribute { }
After:
  public sealed class AspDataFieldAttribute : Attribute
    {
    }

  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method)]
  public sealed class AspDataFieldsAttribute : Attribute
    {
    }

  [AttributeUsage(AttributeTargets.Property)]
  public sealed class AspMethodPropertyAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  public sealed class AspDataFieldAttribute : Attribute { }

  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method)]
  public sealed class AspDataFieldsAttribute : Attribute { }

  [AttributeUsage(AttributeTargets.Property)]
  public sealed class AspMethodPropertyAttribute : Attribute { }
After:
  public sealed class AspDataFieldAttribute : Attribute
    {
    }

  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method)]
  public sealed class AspDataFieldsAttribute : Attribute
    {
    }

  [AttributeUsage(AttributeTargets.Property)]
  public sealed class AspMethodPropertyAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  public sealed class AspDataFieldAttribute : Attribute { }

  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method)]
  public sealed class AspDataFieldsAttribute : Attribute { }

  [AttributeUsage(AttributeTargets.Property)]
  public sealed class AspMethodPropertyAttribute : Attribute { }
After:
  public sealed class AspDataFieldAttribute : Attribute
    {
    }

  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method)]
  public sealed class AspDataFieldsAttribute : Attribute
    {
    }

  [AttributeUsage(AttributeTargets.Property)]
  public sealed class AspMethodPropertyAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  public sealed class AspDataFieldAttribute : Attribute { }

  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method)]
  public sealed class AspDataFieldsAttribute : Attribute { }

  [AttributeUsage(AttributeTargets.Property)]
  public sealed class AspMethodPropertyAttribute : Attribute { }
After:
  public sealed class AspDataFieldAttribute : Attribute
    {
    }

  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method)]
  public sealed class AspDataFieldsAttribute : Attribute
    {
    }

  [AttributeUsage(AttributeTargets.Property)]
  public sealed class AspMethodPropertyAttribute : Attribute
    {
    }
*/
    public sealed class AspDataFieldAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method)]
    public sealed class AspDataFieldsAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property)]
    public sealed class AspMethodPropertyAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
  
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      Attribute = attribute;
After:
      this.Attribute = attribute;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      Attribute = attribute;
After:
      this.Attribute = attribute;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      Attribute = attribute;
After:
      this.Attribute = attribute;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      Attribute = attribute;
After:
      this.Attribute = attribute;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    [NotNull] public string Attribute { get; }
After:
    [NotNull]
        public string Attribute { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    [NotNull] public string Attribute { get; }
After:
    [NotNull]
        public string Attribute { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    [NotNull] public string Attribute { get; }
After:
    [NotNull]
        public string Attribute { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    [NotNull] public string Attribute { get; }
After:
    [NotNull]
        public string Attribute { get; }
*/
  public sealed class AspRequiredAttributeAttribute : Attribute
    {
        public AspRequiredAttributeAttribute([NotNull] string attribute)
        {
            this.Attribute = attribute;
        }

        [NotNull]
        public string Attribute { get; }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public sealed class AspTypePropertyAttribute : Attribute
    {
        public AspTypePropertyAttribute(bool createConstructorReferences)
        {
            this.CreateConstructorReferences = createConstructorReferences;
        }

        public AspTypePropertyAttribute(bool createConstructorReferences)
    {
      this.CreateConstructorReferences = createConstructorReferences;
    }

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    public AspTypePropertyAttribute(bool createConstructorReferences)
    {
      CreateConstructorReferences = createConstructorReferences;
    }
  }

  #endregion

  #region ASP.NET MVC

  [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true)]
After:
    public bool CreateConstructorReferences { get; }
  }

    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true)]
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    public AspTypePropertyAttribute(bool createConstructorReferences)
    {
      CreateConstructorReferences = createConstructorReferences;
    }
  }

  #endregion

  #region ASP.NET MVC

  [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true)]
After:
    public bool CreateConstructorReferences { get; }
  }

    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true)]
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    public AspTypePropertyAttribute(bool createConstructorReferences)
    {
      CreateConstructorReferences = createConstructorReferences;
    }
  }

  #endregion

  #region ASP.NET MVC

  [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true)]
After:
    public bool CreateConstructorReferences { get; }
  }

    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true)]
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    public AspTypePropertyAttribute(bool createConstructorReferences)
    {
      CreateConstructorReferences = createConstructorReferences;
    }
  }

  #endregion

  #region ASP.NET MVC

  [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true)]
After:
    public bool CreateConstructorReferences { get; }
  }

    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true)]
*/
    }

    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true)]
  
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      Format = format;
After:
      this.Format = format;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      Format = format;
After:
      this.Format = format;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      Format = format;
After:
      this.Format = format;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      Format = format;
After:
      this.Format = format;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    [NotNull] public string Format { get; }
After:
    [NotNull]
        public string Format { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    [NotNull] public string Format { get; }
After:
    [NotNull]
        public string Format { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    [NotNull] public string Format { get; }
After:
    [NotNull]
        public string Format { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    [NotNull] public string Format { get; }
After:
    [NotNull]
        public string Format { get; }
*/
  public sealed class AspMvcAreaMasterLocationFormatAttribute : Attribute
    {
        public AspMvcAreaMasterLocationFormatAttribute([NotNull] string format)
        {
            this.Format = format;
        }

        [NotNull]
        public string Format { get; }
    }

    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true)]
  
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      Format = format;
After:
      this.Format = format;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      Format = format;
After:
      this.Format = format;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      Format = format;
After:
      this.Format = format;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      Format = format;
After:
      this.Format = format;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    [NotNull] public string Format { get; }
After:
    [NotNull]
        public string Format { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    [NotNull] public string Format { get; }
After:
    [NotNull]
        public string Format { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    [NotNull] public string Format { get; }
After:
    [NotNull]
        public string Format { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    [NotNull] public string Format { get; }
After:
    [NotNull]
        public string Format { get; }
*/
  public sealed class AspMvcAreaPartialViewLocationFormatAttribute : Attribute
    {
        public AspMvcAreaPartialViewLocationFormatAttribute([NotNull] string format)
        {
            this.Format = format;
        }

        [NotNull]
        public string Format { get; }
    }

    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true)]
  
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      Format = format;
After:
      this.Format = format;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      Format = format;
After:
      this.Format = format;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      Format = format;
After:
      this.Format = format;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      Format = format;
After:
      this.Format = format;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    [NotNull] public string Format { get; }
After:
    [NotNull]
        public string Format { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    [NotNull] public string Format { get; }
After:
    [NotNull]
        public string Format { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    [NotNull] public string Format { get; }
After:
    [NotNull]
        public string Format { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    [NotNull] public string Format { get; }
After:
    [NotNull]
        public string Format { get; }
*/
  public sealed class AspMvcAreaViewLocationFormatAttribute : Attribute
    {
        public AspMvcAreaViewLocationFormatAttribute([NotNull] string format)
        {
            this.Format = format;
        }

        [NotNull]
        public string Format { get; }
    }

    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true)]
  
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      Format = format;
After:
      this.Format = format;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      Format = format;
After:
      this.Format = format;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      Format = format;
After:
      this.Format = format;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      Format = format;
After:
      this.Format = format;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    [NotNull] public string Format { get; }
After:
    [NotNull]
        public string Format { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    [NotNull] public string Format { get; }
After:
    [NotNull]
        public string Format { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    [NotNull] public string Format { get; }
After:
    [NotNull]
        public string Format { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    [NotNull] public string Format { get; }
After:
    [NotNull]
        public string Format { get; }
*/
  public sealed class AspMvcMasterLocationFormatAttribute : Attribute
    {
        public AspMvcMasterLocationFormatAttribute([NotNull] string format)
        {
            this.Format = format;
        }

        [NotNull]
        public string Format { get; }
    }

    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true)]
  
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      Format = format;
After:
      this.Format = format;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      Format = format;
After:
      this.Format = format;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      Format = format;
After:
      this.Format = format;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      Format = format;
After:
      this.Format = format;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    [NotNull] public string Format { get; }
After:
    [NotNull]
        public string Format { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    [NotNull] public string Format { get; }
After:
    [NotNull]
        public string Format { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    [NotNull] public string Format { get; }
After:
    [NotNull]
        public string Format { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    [NotNull] public string Format { get; }
After:
    [NotNull]
        public string Format { get; }
*/
  public sealed class AspMvcPartialViewLocationFormatAttribute : Attribute
    {
        public AspMvcPartialViewLocationFormatAttribute([NotNull] string format)
        {
            this.Format = format;
        }

        [NotNull]
        public string Format { get; }
    }

    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true)]
  
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      Format = format;
After:
      this.Format = format;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      Format = format;
After:
      this.Format = format;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      Format = format;
After:
      this.Format = format;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      Format = format;
After:
      this.Format = format;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    [NotNull] public string Format { get; }
After:
    [NotNull]
        public string Format { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    [NotNull] public string Format { get; }
After:
    [NotNull]
        public string Format { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    [NotNull] public string Format { get; }
After:
    [NotNull]
        public string Format { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    [NotNull] public string Format { get; }
After:
    [NotNull]
        public string Format { get; }
*/
  public sealed class AspMvcViewLocationFormatAttribute : Attribute
    {
        public AspMvcViewLocationFormatAttribute([NotNull] string format)
        {
            this.Format = format;
        }

        [NotNull]
        public string Format { get; }
    }

    /// <summary>
    /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
    /// is an MVC action. If applied to a method, the MVC action name is calculated
    /// implicitly from the context. Use this attribute for custom wrappers similar to
    /// <c>System.Web.Mvc.Html.ChildActionExtensions.RenderAction(HtmlHelper, String)</c>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Property)]
  
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    public AspMvcActionAttribute() { }
After:
    public AspMvcActionAttribute()
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    public AspMvcActionAttribute() { }
After:
    public AspMvcActionAttribute()
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    public AspMvcActionAttribute() { }
After:
    public AspMvcActionAttribute()
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    public AspMvcActionAttribute() { }
After:
    public AspMvcActionAttribute()
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      AnonymousProperty = anonymousProperty;
After:
      this.AnonymousProperty = anonymousProperty;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      AnonymousProperty = anonymousProperty;
After:
      this.AnonymousProperty = anonymousProperty;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      AnonymousProperty = anonymousProperty;
After:
      this.AnonymousProperty = anonymousProperty;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      AnonymousProperty = anonymousProperty;
After:
      this.AnonymousProperty = anonymousProperty;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    [CanBeNull] public string AnonymousProperty { get; }
After:
    [CanBeNull]
        public string AnonymousProperty { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    [CanBeNull] public string AnonymousProperty { get; }
After:
    [CanBeNull]
        public string AnonymousProperty { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    [CanBeNull] public string AnonymousProperty { get; }
After:
    [CanBeNull]
        public string AnonymousProperty { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    [CanBeNull] public string AnonymousProperty { get; }
After:
    [CanBeNull]
        public string AnonymousProperty { get; }
*/
  public sealed class AspMvcActionAttribute : Attribute
    {
        public AspMvcActionAttribute()
        {
        }

        public AspMvcActionAttribute([NotNull] string anonymousProperty)
        {
            this.AnonymousProperty = anonymousProperty;
        }

        [CanBeNull]
        public string AnonymousProperty { get; }
    }

    /// <summary>
    /// ASP.NET MVC attribute. Indicates that the marked parameter is an MVC area.
    /// Use this attribute for custom wrappers similar to
    /// <c>System.Web.Mvc.Html.ChildActionExtensions.RenderAction(HtmlHelper, String)</c>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    public AspMvcAreaAttribute() { }
After:
    public AspMvcAreaAttribute()
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    public AspMvcAreaAttribute() { }
After:
    public AspMvcAreaAttribute()
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    public AspMvcAreaAttribute() { }
After:
    public AspMvcAreaAttribute()
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    public AspMvcAreaAttribute() { }
After:
    public AspMvcAreaAttribute()
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      AnonymousProperty = anonymousProperty;
After:
      this.AnonymousProperty = anonymousProperty;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      AnonymousProperty = anonymousProperty;
After:
      this.AnonymousProperty = anonymousProperty;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      AnonymousProperty = anonymousProperty;
After:
      this.AnonymousProperty = anonymousProperty;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      AnonymousProperty = anonymousProperty;
After:
      this.AnonymousProperty = anonymousProperty;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    [CanBeNull] public string AnonymousProperty { get; }
After:
    [CanBeNull]
        public string AnonymousProperty { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    [CanBeNull] public string AnonymousProperty { get; }
After:
    [CanBeNull]
        public string AnonymousProperty { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    [CanBeNull] public string AnonymousProperty { get; }
After:
    [CanBeNull]
        public string AnonymousProperty { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    [CanBeNull] public string AnonymousProperty { get; }
After:
    [CanBeNull]
        public string AnonymousProperty { get; }
*/
  public sealed class AspMvcAreaAttribute : Attribute
    {
        public AspMvcAreaAttribute()
        {
        }

        public AspMvcAreaAttribute([NotNull] string anonymousProperty)
        {
            this.AnonymousProperty = anonymousProperty;
        }

        [CanBeNull]
        public string AnonymousProperty { get; }
    }

    /// <summary>
    /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter is
    /// an MVC controller. If applied to a method, the MVC controller name is calculated
    /// implicitly from the context. Use this attribute for custom wrappers similar to
    /// <c>System.Web.Mvc.Html.ChildActionExtensions.RenderAction(HtmlHelper, String, String)</c>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Property)]
  
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    public AspMvcControllerAttribute() { }
After:
    public AspMvcControllerAttribute()
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    public AspMvcControllerAttribute() { }
After:
    public AspMvcControllerAttribute()
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    public AspMvcControllerAttribute() { }
After:
    public AspMvcControllerAttribute()
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    public AspMvcControllerAttribute() { }
After:
    public AspMvcControllerAttribute()
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      AnonymousProperty = anonymousProperty;
After:
      this.AnonymousProperty = anonymousProperty;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      AnonymousProperty = anonymousProperty;
After:
      this.AnonymousProperty = anonymousProperty;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      AnonymousProperty = anonymousProperty;
After:
      this.AnonymousProperty = anonymousProperty;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      AnonymousProperty = anonymousProperty;
After:
      this.AnonymousProperty = anonymousProperty;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    [CanBeNull] public string AnonymousProperty { get; }
After:
    [CanBeNull]
        public string AnonymousProperty { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    [CanBeNull] public string AnonymousProperty { get; }
After:
    [CanBeNull]
        public string AnonymousProperty { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    [CanBeNull] public string AnonymousProperty { get; }
After:
    [CanBeNull]
        public string AnonymousProperty { get; }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    [CanBeNull] public string AnonymousProperty { get; }
After:
    [CanBeNull]
        public string AnonymousProperty { get; }
*/
  public sealed class AspMvcControllerAttribute : Attribute
    {
        public AspMvcControllerAttribute()
        {
        }

        public AspMvcControllerAttribute([NotNull] string anonymousProperty)
        {
            this.AnonymousProperty = anonymousProperty;
        }

        [CanBeNull]
        public string AnonymousProperty { get; }
    }

    /// <summary>
    /// ASP.NET MVC attribute. Indicates that the marked parameter is an MVC Master. Use this attribute
    /// for custom wrappers similar to <c>System.Web.Mvc.Controller.View(String, String)</c>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  public sealed class AspMvcMasterAttribute : Attribute { }
After:
  public sealed class AspMvcMasterAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  public sealed class AspMvcMasterAttribute : Attribute { }
After:
  public sealed class AspMvcMasterAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  public sealed class AspMvcMasterAttribute : Attribute { }
After:
  public sealed class AspMvcMasterAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  public sealed class AspMvcMasterAttribute : Attribute { }
After:
  public sealed class AspMvcMasterAttribute : Attribute
    {
    }
*/
    public sealed class AspMvcMasterAttribute : Attribute
    {
    }

    /// <summary>
    /// ASP.NET MVC attribute. Indicates that the marked parameter is an MVC model type. Use this attribute
    /// for custom wrappers similar to <c>System.Web.Mvc.Controller.View(String, Object)</c>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  public sealed class AspMvcModelTypeAttribute : Attribute { }
After:
  public sealed class AspMvcModelTypeAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  public sealed class AspMvcModelTypeAttribute : Attribute { }
After:
  public sealed class AspMvcModelTypeAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  public sealed class AspMvcModelTypeAttribute : Attribute { }
After:
  public sealed class AspMvcModelTypeAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  public sealed class AspMvcModelTypeAttribute : Attribute { }
After:
  public sealed class AspMvcModelTypeAttribute : Attribute
    {
    }
*/
    public sealed class AspMvcModelTypeAttribute : Attribute
    {
    }

    /// <summary>
    /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter is an MVC
    /// partial view. If applied to a method, the MVC partial view name is calculated implicitly
    /// from the context. Use this attribute for custom wrappers similar to
    /// <c>System.Web.Mvc.Html.RenderPartialExtensions.RenderPartial(HtmlHelper, String)</c>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Property)]

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  public sealed class AspMvcPartialViewAttribute : Attribute { }
After:
  public sealed class AspMvcPartialViewAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  public sealed class AspMvcPartialViewAttribute : Attribute { }
After:
  public sealed class AspMvcPartialViewAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  public sealed class AspMvcPartialViewAttribute : Attribute { }
After:
  public sealed class AspMvcPartialViewAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  public sealed class AspMvcPartialViewAttribute : Attribute { }
After:
  public sealed class AspMvcPartialViewAttribute : Attribute
    {
    }
*/
    public sealed class AspMvcPartialViewAttribute : Attribute
    {
    }

    /// <summary>
    /// ASP.NET MVC attribute. Allows disabling inspections for MVC views within a class or a method.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  public sealed class AspMvcSuppressViewErrorAttribute : Attribute { }
After:
  public sealed class AspMvcSuppressViewErrorAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  public sealed class AspMvcSuppressViewErrorAttribute : Attribute { }
After:
  public sealed class AspMvcSuppressViewErrorAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  public sealed class AspMvcSuppressViewErrorAttribute : Attribute { }
After:
  public sealed class AspMvcSuppressViewErrorAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  public sealed class AspMvcSuppressViewErrorAttribute : Attribute { }
After:
  public sealed class AspMvcSuppressViewErrorAttribute : Attribute
    {
    }
*/
    public sealed class AspMvcSuppressViewErrorAttribute : Attribute
    {
    }

    /// <summary>
    /// ASP.NET MVC attribute. Indicates that a parameter is an MVC display template.
    /// Use this attribute for custom wrappers similar to
    /// <c>System.Web.Mvc.Html.DisplayExtensions.DisplayForModel(HtmlHelper, String)</c>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  public sealed class AspMvcDisplayTemplateAttribute : Attribute { }
After:
  public sealed class AspMvcDisplayTemplateAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  public sealed class AspMvcDisplayTemplateAttribute : Attribute { }
After:
  public sealed class AspMvcDisplayTemplateAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  public sealed class AspMvcDisplayTemplateAttribute : Attribute { }
After:
  public sealed class AspMvcDisplayTemplateAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  public sealed class AspMvcDisplayTemplateAttribute : Attribute { }
After:
  public sealed class AspMvcDisplayTemplateAttribute : Attribute
    {
    }
*/
    public sealed class AspMvcDisplayTemplateAttribute : Attribute
    {
    }

    /// <summary>
    /// ASP.NET MVC attribute. Indicates that the marked parameter is an MVC editor template.
    /// Use this attribute for custom wrappers similar to
    /// <c>System.Web.Mvc.Html.EditorExtensions.EditorForModel(HtmlHelper, String)</c>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  public sealed class AspMvcEditorTemplateAttribute : Attribute { }
After:
  public sealed class AspMvcEditorTemplateAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  public sealed class AspMvcEditorTemplateAttribute : Attribute { }
After:
  public sealed class AspMvcEditorTemplateAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  public sealed class AspMvcEditorTemplateAttribute : Attribute { }
After:
  public sealed class AspMvcEditorTemplateAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  public sealed class AspMvcEditorTemplateAttribute : Attribute { }
After:
  public sealed class AspMvcEditorTemplateAttribute : Attribute
    {
    }
*/
    public sealed class AspMvcEditorTemplateAttribute : Attribute
    {
    }

    /// <summary>
    /// ASP.NET MVC attribute. Indicates that the marked parameter is an MVC template.
    /// Use this attribute for custom wrappers similar to
    /// <c>System.ComponentModel.DataAnnotations.UIHintAttribute(System.String)</c>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  public sealed class AspMvcTemplateAttribute : Attribute { }

  /// <summary>
  /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
  /// is an MVC view component. If applied to a method, the MVC view name is calculated implicitly
  /// from the context. Use this attribute for custom wrappers similar to
  /// <c>System.Web.Mvc.Controller.View(Object)</c>.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class AspMvcViewAttribute : Attribute { }

  /// <summary>
  /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
  /// is an MVC view component name.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class AspMvcViewComponentAttribute : Attribute { }

  /// <summary>
  /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
  /// is an MVC view component view. If applied to a method, the MVC view component view name is default.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class AspMvcViewComponentViewAttribute : Attribute { }

  /// <summary>
  /// ASP.NET MVC attribute. When applied to a parameter of an attribute,
  /// indicates that this parameter is an MVC action name.
  /// </summary>
  /// <example><code>
  /// [ActionName("Foo")]
  /// public ActionResult Login(string returnUrl) {
  ///   ViewBag.ReturnUrl = Url.Action("Foo"); // OK
  ///   return RedirectToAction("Bar"); // Error: Cannot resolve action
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property)]
  public sealed class AspMvcActionSelectorAttribute : Attribute { }

  #endregion

  #region ASP.NET Routing

  /// <summary>
  /// Indicates that the marked parameter, field, or property is a route template.
  /// </summary>
  /// <remarks>
  /// This attribute allows IDE to recognize the use of web frameworks' route templates
  /// to enable syntax highlighting, code completion, navigation, rename and other features in string literals.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class RouteTemplateAttribute : Attribute { }

  /// <summary>
  /// Indicates that the marked type is custom route parameter constraint,
  /// which is registered in application's Startup with name <c>ConstraintName</c>
  /// </summary>
  /// <remarks>
  /// You can specify <c>ProposedType</c> if target constraint matches only route parameters of specific type,
  /// it will allow IDE to create method's parameter from usage in route template
  /// with specified type instead of default <c>System.String</c>
  /// and check if constraint's proposed type conflicts with matched parameter's type
After:
  public sealed class AspMvcTemplateAttribute : Attribute
    {
    }

  /// <summary>
  /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
  /// is an MVC view component. If applied to a method, the MVC view name is calculated implicitly
  /// from the context. Use this attribute for custom wrappers similar to
  /// <c>System.Web.Mvc.Controller.View(Object)</c>.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class AspMvcViewAttribute : Attribute
    {
    }

  /// <summary>
  /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
  /// is an MVC view component name.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class AspMvcViewComponentAttribute : Attribute
    {
    }

  /// <summary>
  /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
  /// is an MVC view component view. If applied to a method, the MVC view component view name is default.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class AspMvcViewComponentViewAttribute : Attribute
    {
    }

  /// <summary>
  /// ASP.NET MVC attribute. When applied to a parameter of an attribute,
  /// indicates that this parameter is an MVC action name.
  /// </summary>
  /// <example><code>
  /// [ActionName("Foo")]
  /// public ActionResult Login(string returnUrl) {
  ///   ViewBag.ReturnUrl = Url.Action("Foo"); // OK
  ///   return RedirectToAction("Bar"); // Error: Cannot resolve action
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property)]
  public sealed class AspMvcActionSelectorAttribute : Attribute
    {
    }



    /// <summary>
    /// Indicates that the marked parameter, field, or property is a route template.
    /// </summary>
    /// <remarks>
    /// This attribute allows IDE to recognize the use of web frameworks' route templates
    /// to enable syntax highlighting, code completion, navigation, rename and other features in string literals.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class RouteTemplateAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked type is custom route parameter constraint,
  /// which is registered in application's Startup with name <c>ConstraintName</c>.
  /// </summary>
  /// <remarks>
  /// You can specify <c>ProposedType</c> if target constraint matches only route parameters of specific type,
  /// it will allow IDE to create method's parameter from usage in route template
  /// with specified type instead of default <c>System.String</c>
  /// and check if constraint's proposed type conflicts with matched parameter's type.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  public sealed class AspMvcTemplateAttribute : Attribute { }

  /// <summary>
  /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
  /// is an MVC view component. If applied to a method, the MVC view name is calculated implicitly
  /// from the context. Use this attribute for custom wrappers similar to
  /// <c>System.Web.Mvc.Controller.View(Object)</c>.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class AspMvcViewAttribute : Attribute { }

  /// <summary>
  /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
  /// is an MVC view component name.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class AspMvcViewComponentAttribute : Attribute { }

  /// <summary>
  /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
  /// is an MVC view component view. If applied to a method, the MVC view component view name is default.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class AspMvcViewComponentViewAttribute : Attribute { }

  /// <summary>
  /// ASP.NET MVC attribute. When applied to a parameter of an attribute,
  /// indicates that this parameter is an MVC action name.
  /// </summary>
  /// <example><code>
  /// [ActionName("Foo")]
  /// public ActionResult Login(string returnUrl) {
  ///   ViewBag.ReturnUrl = Url.Action("Foo"); // OK
  ///   return RedirectToAction("Bar"); // Error: Cannot resolve action
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property)]
  public sealed class AspMvcActionSelectorAttribute : Attribute { }

  #endregion

  #region ASP.NET Routing

  /// <summary>
  /// Indicates that the marked parameter, field, or property is a route template.
  /// </summary>
  /// <remarks>
  /// This attribute allows IDE to recognize the use of web frameworks' route templates
  /// to enable syntax highlighting, code completion, navigation, rename and other features in string literals.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class RouteTemplateAttribute : Attribute { }

  /// <summary>
  /// Indicates that the marked type is custom route parameter constraint,
  /// which is registered in application's Startup with name <c>ConstraintName</c>
  /// </summary>
  /// <remarks>
  /// You can specify <c>ProposedType</c> if target constraint matches only route parameters of specific type,
  /// it will allow IDE to create method's parameter from usage in route template
  /// with specified type instead of default <c>System.String</c>
  /// and check if constraint's proposed type conflicts with matched parameter's type
After:
  public sealed class AspMvcTemplateAttribute : Attribute
    {
    }

  /// <summary>
  /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
  /// is an MVC view component. If applied to a method, the MVC view name is calculated implicitly
  /// from the context. Use this attribute for custom wrappers similar to
  /// <c>System.Web.Mvc.Controller.View(Object)</c>.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class AspMvcViewAttribute : Attribute
    {
    }

  /// <summary>
  /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
  /// is an MVC view component name.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class AspMvcViewComponentAttribute : Attribute
    {
    }

  /// <summary>
  /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
  /// is an MVC view component view. If applied to a method, the MVC view component view name is default.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class AspMvcViewComponentViewAttribute : Attribute
    {
    }

  /// <summary>
  /// ASP.NET MVC attribute. When applied to a parameter of an attribute,
  /// indicates that this parameter is an MVC action name.
  /// </summary>
  /// <example><code>
  /// [ActionName("Foo")]
  /// public ActionResult Login(string returnUrl) {
  ///   ViewBag.ReturnUrl = Url.Action("Foo"); // OK
  ///   return RedirectToAction("Bar"); // Error: Cannot resolve action
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property)]
  public sealed class AspMvcActionSelectorAttribute : Attribute
    {
    }



    /// <summary>
    /// Indicates that the marked parameter, field, or property is a route template.
    /// </summary>
    /// <remarks>
    /// This attribute allows IDE to recognize the use of web frameworks' route templates
    /// to enable syntax highlighting, code completion, navigation, rename and other features in string literals.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class RouteTemplateAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked type is custom route parameter constraint,
  /// which is registered in application's Startup with name <c>ConstraintName</c>.
  /// </summary>
  /// <remarks>
  /// You can specify <c>ProposedType</c> if target constraint matches only route parameters of specific type,
  /// it will allow IDE to create method's parameter from usage in route template
  /// with specified type instead of default <c>System.String</c>
  /// and check if constraint's proposed type conflicts with matched parameter's type.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  public sealed class AspMvcTemplateAttribute : Attribute { }

  /// <summary>
  /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
  /// is an MVC view component. If applied to a method, the MVC view name is calculated implicitly
  /// from the context. Use this attribute for custom wrappers similar to
  /// <c>System.Web.Mvc.Controller.View(Object)</c>.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class AspMvcViewAttribute : Attribute { }

  /// <summary>
  /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
  /// is an MVC view component name.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class AspMvcViewComponentAttribute : Attribute { }

  /// <summary>
  /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
  /// is an MVC view component view. If applied to a method, the MVC view component view name is default.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class AspMvcViewComponentViewAttribute : Attribute { }

  /// <summary>
  /// ASP.NET MVC attribute. When applied to a parameter of an attribute,
  /// indicates that this parameter is an MVC action name.
  /// </summary>
  /// <example><code>
  /// [ActionName("Foo")]
  /// public ActionResult Login(string returnUrl) {
  ///   ViewBag.ReturnUrl = Url.Action("Foo"); // OK
  ///   return RedirectToAction("Bar"); // Error: Cannot resolve action
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property)]
  public sealed class AspMvcActionSelectorAttribute : Attribute { }

  #endregion

  #region ASP.NET Routing

  /// <summary>
  /// Indicates that the marked parameter, field, or property is a route template.
  /// </summary>
  /// <remarks>
  /// This attribute allows IDE to recognize the use of web frameworks' route templates
  /// to enable syntax highlighting, code completion, navigation, rename and other features in string literals.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class RouteTemplateAttribute : Attribute { }

  /// <summary>
  /// Indicates that the marked type is custom route parameter constraint,
  /// which is registered in application's Startup with name <c>ConstraintName</c>
  /// </summary>
  /// <remarks>
  /// You can specify <c>ProposedType</c> if target constraint matches only route parameters of specific type,
  /// it will allow IDE to create method's parameter from usage in route template
  /// with specified type instead of default <c>System.String</c>
  /// and check if constraint's proposed type conflicts with matched parameter's type
After:
  public sealed class AspMvcTemplateAttribute : Attribute
    {
    }

  /// <summary>
  /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
  /// is an MVC view component. If applied to a method, the MVC view name is calculated implicitly
  /// from the context. Use this attribute for custom wrappers similar to
  /// <c>System.Web.Mvc.Controller.View(Object)</c>.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class AspMvcViewAttribute : Attribute
    {
    }

  /// <summary>
  /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
  /// is an MVC view component name.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class AspMvcViewComponentAttribute : Attribute
    {
    }

  /// <summary>
  /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
  /// is an MVC view component view. If applied to a method, the MVC view component view name is default.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class AspMvcViewComponentViewAttribute : Attribute
    {
    }

  /// <summary>
  /// ASP.NET MVC attribute. When applied to a parameter of an attribute,
  /// indicates that this parameter is an MVC action name.
  /// </summary>
  /// <example><code>
  /// [ActionName("Foo")]
  /// public ActionResult Login(string returnUrl) {
  ///   ViewBag.ReturnUrl = Url.Action("Foo"); // OK
  ///   return RedirectToAction("Bar"); // Error: Cannot resolve action
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property)]
  public sealed class AspMvcActionSelectorAttribute : Attribute
    {
    }



    /// <summary>
    /// Indicates that the marked parameter, field, or property is a route template.
    /// </summary>
    /// <remarks>
    /// This attribute allows IDE to recognize the use of web frameworks' route templates
    /// to enable syntax highlighting, code completion, navigation, rename and other features in string literals.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class RouteTemplateAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked type is custom route parameter constraint,
  /// which is registered in application's Startup with name <c>ConstraintName</c>.
  /// </summary>
  /// <remarks>
  /// You can specify <c>ProposedType</c> if target constraint matches only route parameters of specific type,
  /// it will allow IDE to create method's parameter from usage in route template
  /// with specified type instead of default <c>System.String</c>
  /// and check if constraint's proposed type conflicts with matched parameter's type.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  public sealed class AspMvcTemplateAttribute : Attribute { }

  /// <summary>
  /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
  /// is an MVC view component. If applied to a method, the MVC view name is calculated implicitly
  /// from the context. Use this attribute for custom wrappers similar to
  /// <c>System.Web.Mvc.Controller.View(Object)</c>.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class AspMvcViewAttribute : Attribute { }

  /// <summary>
  /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
  /// is an MVC view component name.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class AspMvcViewComponentAttribute : Attribute { }

  /// <summary>
  /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
  /// is an MVC view component view. If applied to a method, the MVC view component view name is default.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class AspMvcViewComponentViewAttribute : Attribute { }

  /// <summary>
  /// ASP.NET MVC attribute. When applied to a parameter of an attribute,
  /// indicates that this parameter is an MVC action name.
  /// </summary>
  /// <example><code>
  /// [ActionName("Foo")]
  /// public ActionResult Login(string returnUrl) {
  ///   ViewBag.ReturnUrl = Url.Action("Foo"); // OK
  ///   return RedirectToAction("Bar"); // Error: Cannot resolve action
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property)]
  public sealed class AspMvcActionSelectorAttribute : Attribute { }

  #endregion

  #region ASP.NET Routing

  /// <summary>
  /// Indicates that the marked parameter, field, or property is a route template.
  /// </summary>
  /// <remarks>
  /// This attribute allows IDE to recognize the use of web frameworks' route templates
  /// to enable syntax highlighting, code completion, navigation, rename and other features in string literals.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class RouteTemplateAttribute : Attribute { }

  /// <summary>
  /// Indicates that the marked type is custom route parameter constraint,
  /// which is registered in application's Startup with name <c>ConstraintName</c>
  /// </summary>
  /// <remarks>
  /// You can specify <c>ProposedType</c> if target constraint matches only route parameters of specific type,
  /// it will allow IDE to create method's parameter from usage in route template
  /// with specified type instead of default <c>System.String</c>
  /// and check if constraint's proposed type conflicts with matched parameter's type
After:
  public sealed class AspMvcTemplateAttribute : Attribute
    {
    }

  /// <summary>
  /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
  /// is an MVC view component. If applied to a method, the MVC view name is calculated implicitly
  /// from the context. Use this attribute for custom wrappers similar to
  /// <c>System.Web.Mvc.Controller.View(Object)</c>.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class AspMvcViewAttribute : Attribute
    {
    }

  /// <summary>
  /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
  /// is an MVC view component name.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class AspMvcViewComponentAttribute : Attribute
    {
    }

  /// <summary>
  /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
  /// is an MVC view component view. If applied to a method, the MVC view component view name is default.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class AspMvcViewComponentViewAttribute : Attribute
    {
    }

  /// <summary>
  /// ASP.NET MVC attribute. When applied to a parameter of an attribute,
  /// indicates that this parameter is an MVC action name.
  /// </summary>
  /// <example><code>
  /// [ActionName("Foo")]
  /// public ActionResult Login(string returnUrl) {
  ///   ViewBag.ReturnUrl = Url.Action("Foo"); // OK
  ///   return RedirectToAction("Bar"); // Error: Cannot resolve action
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property)]
  public sealed class AspMvcActionSelectorAttribute : Attribute
    {
    }



    /// <summary>
    /// Indicates that the marked parameter, field, or property is a route template.
    /// </summary>
    /// <remarks>
    /// This attribute allows IDE to recognize the use of web frameworks' route templates
    /// to enable syntax highlighting, code completion, navigation, rename and other features in string literals.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class RouteTemplateAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked type is custom route parameter constraint,
  /// which is registered in application's Startup with name <c>ConstraintName</c>.
  /// </summary>
  /// <remarks>
  /// You can specify <c>ProposedType</c> if target constraint matches only route parameters of specific type,
  /// it will allow IDE to create method's parameter from usage in route template
  /// with specified type instead of default <c>System.String</c>
  /// and check if constraint's proposed type conflicts with matched parameter's type.
*/
    public sealed class AspMvcTemplateAttribute : Attribute
    {
    }

    /// <summary>
    /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
    /// is an MVC view component. If applied to a method, the MVC view name is calculated implicitly
    /// from the context. Use this attribute for custom wrappers similar to
    /// <c>System.Web.Mvc.Controller.View(Object)</c>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class AspMvcViewAttribute : Attribute
    {
    }

    /// <summary>
    /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
    /// is an MVC view component name.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class AspMvcViewComponentAttribute : Attribute
    {
    }

    /// <summary>
    /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
    /// is an MVC view component view. If applied to a method, the MVC view component view name is default.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class AspMvcViewComponentViewAttribute : Attribute
    {
    }

    /// <summary>
    /// ASP.NET MVC attribute. When applied to a parameter of an attribute,
    /// indicates that this parameter is an MVC action name.
    /// </summary>
    /// <example><code>
    /// [ActionName("Foo")]
    /// public ActionResult Login(string returnUrl) {
    ///   ViewBag.ReturnUrl = Url.Action("Foo"); // OK
    ///   return RedirectToAction("Bar"); // Error: Cannot resolve action
    /// }
    /// </code></example>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property)]
    public sealed class AspMvcActionSelectorAttribute : Attribute
    {
    }



    /// <summary>
    /// Indicates that the marked parameter, field, or property is a route template.
    /// </summary>
    /// <remarks>
    /// This attribute allows IDE to recognize the use of web frameworks' route templates
    /// to enable syntax highlighting, code completion, navigation, rename and other features in string literals.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class RouteTemplateAttribute : Attribute
    {
    }

    /// <summary>
    /// Indicates that the marked type is custom route parameter constraint,
    /// which is registered in application's Startup with name <c>ConstraintName</c>.
    /// </summary>
    /// <remarks>
    /// You can specify <c>ProposedType</c> if target constraint matches only route parameters of specific type,
    /// it will allow IDE to create method's parameter from usage in route template
    /// with specified type instead of default <c>System.String</c>
    /// and check if constraint's proposed type conflicts with matched parameter's type.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class RouteParameterConstraintAttribute : Attribute
  
/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
    [NotNull] public string ConstraintName { get; }
    [CanBeNull] public Type ProposedType { get; set; }

    public RouteParameterConstraintAttribute([NotNull] string constraintName)
After:
    public RouteParameterConstraintAttribute([NotNull] string constraintName)
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
    [NotNull] public string ConstraintName { get; }
    [CanBeNull] public Type ProposedType { get; set; }

    public RouteParameterConstraintAttribute([NotNull] string constraintName)
After:
    public RouteParameterConstraintAttribute([NotNull] string constraintName)
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
    [NotNull] public string ConstraintName { get; }
    [CanBeNull] public Type ProposedType { get; set; }

    public RouteParameterConstraintAttribute([NotNull] string constraintName)
After:
    public RouteParameterConstraintAttribute([NotNull] string constraintName)
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
    [NotNull] public string ConstraintName { get; }
    [CanBeNull] public Type ProposedType { get; set; }

    public RouteParameterConstraintAttribute([NotNull] string constraintName)
After:
    public RouteParameterConstraintAttribute([NotNull] string constraintName)
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      ConstraintName = constraintName;
After:
      this.ConstraintName = constraintName;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      ConstraintName = constraintName;
After:
      this.ConstraintName = constraintName;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      ConstraintName = constraintName;
After:
      this.ConstraintName = constraintName;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      ConstraintName = constraintName;
After:
      this.ConstraintName = constraintName;
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  }

  /// <summary>
  /// Indicates that the marked parameter, field, or property is an URI string.
  /// </summary>
  /// <remarks>
  /// This attribute enables code completion, navigation, rename and other features
  /// in URI string literals assigned to annotated parameter, field or property.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class UriStringAttribute : Attribute
  {
    public UriStringAttribute() { }

    public UriStringAttribute(string httpVerb)
    {
      HttpVerb = httpVerb;
    }

    [CanBeNull] public string HttpVerb { get; }
  }

  /// <summary>
  /// Indicates that the marked method declares routing convention for ASP.NET
  /// </summary>
  /// <remarks>
  /// IDE will analyze all usages of methods marked with this attribute,
  /// and will add all routes to completion, navigation and other features over URI strings
  /// </remarks>
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class AspRouteConventionAttribute : Attribute
  {
    public AspRouteConventionAttribute() { }

    public AspRouteConventionAttribute(string predefinedPattern)
    {
      PredefinedPattern = predefinedPattern;
    }

    [CanBeNull] public string PredefinedPattern { get; }
  }

  /// <summary>
  /// Indicates that the marked method parameter contains default route values of routing convention for ASP.NET
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class AspDefaultRouteValuesAttribute : Attribute { }

  /// <summary>
  /// Indicates that the marked method parameter contains constraints on route values of routing convention for ASP.NET
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class AspRouteValuesConstraintsAttribute : Attribute { }

  /// <summary>
  /// Indicates that the marked parameter or property contains routing order provided by ASP.NET routing attribute
  /// </summary>
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
  public sealed class AspRouteOrderAttribute : Attribute { }

  /// <summary>
  /// Indicates that the marked parameter or property contains HTTP verbs provided by ASP.NET routing attribute
  /// </summary>
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
  public sealed class AspRouteVerbsAttribute : Attribute { }

  /// <summary>
  /// Indicates that the marked attribute is used for attribute routing in ASP.NET
  /// </summary>
  /// <remarks>
  /// IDE will analyze all usages of attributes marked with this attribute,
  /// and will add all routes to completion, navigation and other features over URI strings
  /// </remarks>
  [AttributeUsage(AttributeTargets.Class)]
  public sealed class AspAttributeRoutingAttribute : Attribute
  {
    public string HttpVerb { get; set; }
  }

  /// <summary>
  /// Indicates that the marked method declares ASP.NET Minimal API endpoint
  /// </summary>
  /// <remarks>
  /// IDE will analyze all usages of methods marked with this attribute,
  /// and will add all routes to completion, navigation and other features over URI strings
  /// </remarks>
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class AspMinimalApiDeclarationAttribute : Attribute
  {
    public string HttpVerb { get; set; }
  }

  /// <summary>
  /// Indicates that the marked parameter contains ASP.NET Minimal API endpoint handler
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class AspMinimalApiHandlerAttribute : Attribute { }

  #endregion

  #region Razor

  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.Field)]
  public sealed class HtmlElementAttributesAttribute : Attribute
  {
    public HtmlElementAttributesAttribute() { }

    public HtmlElementAttributesAttribute([NotNull] string name)
    {
      Name = name;
    }

    [CanBeNull] public string Name { get; }
  }

  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class HtmlAttributeValueAttribute : Attribute
  {
    public HtmlAttributeValueAttribute([NotNull] string name)
    {
      Name = name;
    }

    [NotNull] public string Name { get; }
  }

  /// <summary>
  /// Razor attribute. Indicates that the marked parameter or method is a Razor section.
  /// Use this attribute for custom wrappers similar to
  /// <c>System.Web.WebPages.WebPageBase.RenderSection(String)</c>.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method)]
  public sealed class RazorSectionAttribute : Attribute { }

  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorImportNamespaceAttribute : Attribute
  {
    public RazorImportNamespaceAttribute([NotNull] string name)
    {
      Name = name;
    }

    [NotNull] public string Name { get; }
  }

  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorInjectionAttribute : Attribute
  {
    public RazorInjectionAttribute([NotNull] string type, [NotNull] string fieldName)
    {
      Type = type;
      FieldName = fieldName;
    }

    [NotNull] public string Type { get; }

    [NotNull] public string FieldName { get; }
  }

  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorDirectiveAttribute : Attribute
  {
    public RazorDirectiveAttribute([NotNull] string directive)
    {
      Directive = directive;
    }

    [NotNull] public string Directive { get; }
  }
After:
    [NotNull]
        public string ConstraintName { get; }

    [CanBeNull]
        public Type ProposedType { get; set; }
  }

  /// <summary>
  /// Indicates that the marked parameter, field, or property is an URI string.
  /// </summary>
  /// <remarks>
  /// This attribute enables code completion, navigation, rename and other features
  /// in URI string literals assigned to annotated parameter, field or property.
  /// </remarks>
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  }

  /// <summary>
  /// Indicates that the marked parameter, field, or property is an URI string.
  /// </summary>
  /// <remarks>
  /// This attribute enables code completion, navigation, rename and other features
  /// in URI string literals assigned to annotated parameter, field or property.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class UriStringAttribute : Attribute
  {
    public UriStringAttribute() { }

    public UriStringAttribute(string httpVerb)
    {
      HttpVerb = httpVerb;
    }

    [CanBeNull] public string HttpVerb { get; }
  }

  /// <summary>
  /// Indicates that the marked method declares routing convention for ASP.NET
  /// </summary>
  /// <remarks>
  /// IDE will analyze all usages of methods marked with this attribute,
  /// and will add all routes to completion, navigation and other features over URI strings
  /// </remarks>
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class AspRouteConventionAttribute : Attribute
  {
    public AspRouteConventionAttribute() { }

    public AspRouteConventionAttribute(string predefinedPattern)
    {
      PredefinedPattern = predefinedPattern;
    }

    [CanBeNull] public string PredefinedPattern { get; }
  }

  /// <summary>
  /// Indicates that the marked method parameter contains default route values of routing convention for ASP.NET
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class AspDefaultRouteValuesAttribute : Attribute { }

  /// <summary>
  /// Indicates that the marked method parameter contains constraints on route values of routing convention for ASP.NET
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class AspRouteValuesConstraintsAttribute : Attribute { }

  /// <summary>
  /// Indicates that the marked parameter or property contains routing order provided by ASP.NET routing attribute
  /// </summary>
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
  public sealed class AspRouteOrderAttribute : Attribute { }

  /// <summary>
  /// Indicates that the marked parameter or property contains HTTP verbs provided by ASP.NET routing attribute
  /// </summary>
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
  public sealed class AspRouteVerbsAttribute : Attribute { }

  /// <summary>
  /// Indicates that the marked attribute is used for attribute routing in ASP.NET
  /// </summary>
  /// <remarks>
  /// IDE will analyze all usages of attributes marked with this attribute,
  /// and will add all routes to completion, navigation and other features over URI strings
  /// </remarks>
  [AttributeUsage(AttributeTargets.Class)]
  public sealed class AspAttributeRoutingAttribute : Attribute
  {
    public string HttpVerb { get; set; }
  }

  /// <summary>
  /// Indicates that the marked method declares ASP.NET Minimal API endpoint
  /// </summary>
  /// <remarks>
  /// IDE will analyze all usages of methods marked with this attribute,
  /// and will add all routes to completion, navigation and other features over URI strings
  /// </remarks>
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class AspMinimalApiDeclarationAttribute : Attribute
  {
    public string HttpVerb { get; set; }
  }

  /// <summary>
  /// Indicates that the marked parameter contains ASP.NET Minimal API endpoint handler
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class AspMinimalApiHandlerAttribute : Attribute { }

  #endregion

  #region Razor

  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.Field)]
  public sealed class HtmlElementAttributesAttribute : Attribute
  {
    public HtmlElementAttributesAttribute() { }

    public HtmlElementAttributesAttribute([NotNull] string name)
    {
      Name = name;
    }

    [CanBeNull] public string Name { get; }
  }

  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class HtmlAttributeValueAttribute : Attribute
  {
    public HtmlAttributeValueAttribute([NotNull] string name)
    {
      Name = name;
    }

    [NotNull] public string Name { get; }
  }

  /// <summary>
  /// Razor attribute. Indicates that the marked parameter or method is a Razor section.
  /// Use this attribute for custom wrappers similar to
  /// <c>System.Web.WebPages.WebPageBase.RenderSection(String)</c>.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method)]
  public sealed class RazorSectionAttribute : Attribute { }

  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorImportNamespaceAttribute : Attribute
  {
    public RazorImportNamespaceAttribute([NotNull] string name)
    {
      Name = name;
    }

    [NotNull] public string Name { get; }
  }

  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorInjectionAttribute : Attribute
  {
    public RazorInjectionAttribute([NotNull] string type, [NotNull] string fieldName)
    {
      Type = type;
      FieldName = fieldName;
    }

    [NotNull] public string Type { get; }

    [NotNull] public string FieldName { get; }
  }

  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorDirectiveAttribute : Attribute
  {
    public RazorDirectiveAttribute([NotNull] string directive)
    {
      Directive = directive;
    }

    [NotNull] public string Directive { get; }
  }
After:
    [NotNull]
        public string ConstraintName { get; }

    [CanBeNull]
        public Type ProposedType { get; set; }
  }

  /// <summary>
  /// Indicates that the marked parameter, field, or property is an URI string.
  /// </summary>
  /// <remarks>
  /// This attribute enables code completion, navigation, rename and other features
  /// in URI string literals assigned to annotated parameter, field or property.
  /// </remarks>
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  }

  /// <summary>
  /// Indicates that the marked parameter, field, or property is an URI string.
  /// </summary>
  /// <remarks>
  /// This attribute enables code completion, navigation, rename and other features
  /// in URI string literals assigned to annotated parameter, field or property.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class UriStringAttribute : Attribute
  {
    public UriStringAttribute() { }

    public UriStringAttribute(string httpVerb)
    {
      HttpVerb = httpVerb;
    }

    [CanBeNull] public string HttpVerb { get; }
  }

  /// <summary>
  /// Indicates that the marked method declares routing convention for ASP.NET
  /// </summary>
  /// <remarks>
  /// IDE will analyze all usages of methods marked with this attribute,
  /// and will add all routes to completion, navigation and other features over URI strings
  /// </remarks>
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class AspRouteConventionAttribute : Attribute
  {
    public AspRouteConventionAttribute() { }

    public AspRouteConventionAttribute(string predefinedPattern)
    {
      PredefinedPattern = predefinedPattern;
    }

    [CanBeNull] public string PredefinedPattern { get; }
  }

  /// <summary>
  /// Indicates that the marked method parameter contains default route values of routing convention for ASP.NET
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class AspDefaultRouteValuesAttribute : Attribute { }

  /// <summary>
  /// Indicates that the marked method parameter contains constraints on route values of routing convention for ASP.NET
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class AspRouteValuesConstraintsAttribute : Attribute { }

  /// <summary>
  /// Indicates that the marked parameter or property contains routing order provided by ASP.NET routing attribute
  /// </summary>
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
  public sealed class AspRouteOrderAttribute : Attribute { }

  /// <summary>
  /// Indicates that the marked parameter or property contains HTTP verbs provided by ASP.NET routing attribute
  /// </summary>
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
  public sealed class AspRouteVerbsAttribute : Attribute { }

  /// <summary>
  /// Indicates that the marked attribute is used for attribute routing in ASP.NET
  /// </summary>
  /// <remarks>
  /// IDE will analyze all usages of attributes marked with this attribute,
  /// and will add all routes to completion, navigation and other features over URI strings
  /// </remarks>
  [AttributeUsage(AttributeTargets.Class)]
  public sealed class AspAttributeRoutingAttribute : Attribute
  {
    public string HttpVerb { get; set; }
  }

  /// <summary>
  /// Indicates that the marked method declares ASP.NET Minimal API endpoint
  /// </summary>
  /// <remarks>
  /// IDE will analyze all usages of methods marked with this attribute,
  /// and will add all routes to completion, navigation and other features over URI strings
  /// </remarks>
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class AspMinimalApiDeclarationAttribute : Attribute
  {
    public string HttpVerb { get; set; }
  }

  /// <summary>
  /// Indicates that the marked parameter contains ASP.NET Minimal API endpoint handler
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class AspMinimalApiHandlerAttribute : Attribute { }

  #endregion

  #region Razor

  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.Field)]
  public sealed class HtmlElementAttributesAttribute : Attribute
  {
    public HtmlElementAttributesAttribute() { }

    public HtmlElementAttributesAttribute([NotNull] string name)
    {
      Name = name;
    }

    [CanBeNull] public string Name { get; }
  }

  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class HtmlAttributeValueAttribute : Attribute
  {
    public HtmlAttributeValueAttribute([NotNull] string name)
    {
      Name = name;
    }

    [NotNull] public string Name { get; }
  }

  /// <summary>
  /// Razor attribute. Indicates that the marked parameter or method is a Razor section.
  /// Use this attribute for custom wrappers similar to
  /// <c>System.Web.WebPages.WebPageBase.RenderSection(String)</c>.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method)]
  public sealed class RazorSectionAttribute : Attribute { }

  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorImportNamespaceAttribute : Attribute
  {
    public RazorImportNamespaceAttribute([NotNull] string name)
    {
      Name = name;
    }

    [NotNull] public string Name { get; }
  }

  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorInjectionAttribute : Attribute
  {
    public RazorInjectionAttribute([NotNull] string type, [NotNull] string fieldName)
    {
      Type = type;
      FieldName = fieldName;
    }

    [NotNull] public string Type { get; }

    [NotNull] public string FieldName { get; }
  }

  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorDirectiveAttribute : Attribute
  {
    public RazorDirectiveAttribute([NotNull] string directive)
    {
      Directive = directive;
    }

    [NotNull] public string Directive { get; }
  }
After:
    [NotNull]
        public string ConstraintName { get; }

    [CanBeNull]
        public Type ProposedType { get; set; }
  }

  /// <summary>
  /// Indicates that the marked parameter, field, or property is an URI string.
  /// </summary>
  /// <remarks>
  /// This attribute enables code completion, navigation, rename and other features
  /// in URI string literals assigned to annotated parameter, field or property.
  /// </remarks>
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  }

  /// <summary>
  /// Indicates that the marked parameter, field, or property is an URI string.
  /// </summary>
  /// <remarks>
  /// This attribute enables code completion, navigation, rename and other features
  /// in URI string literals assigned to annotated parameter, field or property.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class UriStringAttribute : Attribute
  {
    public UriStringAttribute() { }

    public UriStringAttribute(string httpVerb)
    {
      HttpVerb = httpVerb;
    }

    [CanBeNull] public string HttpVerb { get; }
  }

  /// <summary>
  /// Indicates that the marked method declares routing convention for ASP.NET
  /// </summary>
  /// <remarks>
  /// IDE will analyze all usages of methods marked with this attribute,
  /// and will add all routes to completion, navigation and other features over URI strings
  /// </remarks>
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class AspRouteConventionAttribute : Attribute
  {
    public AspRouteConventionAttribute() { }

    public AspRouteConventionAttribute(string predefinedPattern)
    {
      PredefinedPattern = predefinedPattern;
    }

    [CanBeNull] public string PredefinedPattern { get; }
  }

  /// <summary>
  /// Indicates that the marked method parameter contains default route values of routing convention for ASP.NET
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class AspDefaultRouteValuesAttribute : Attribute { }

  /// <summary>
  /// Indicates that the marked method parameter contains constraints on route values of routing convention for ASP.NET
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class AspRouteValuesConstraintsAttribute : Attribute { }

  /// <summary>
  /// Indicates that the marked parameter or property contains routing order provided by ASP.NET routing attribute
  /// </summary>
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
  public sealed class AspRouteOrderAttribute : Attribute { }

  /// <summary>
  /// Indicates that the marked parameter or property contains HTTP verbs provided by ASP.NET routing attribute
  /// </summary>
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
  public sealed class AspRouteVerbsAttribute : Attribute { }

  /// <summary>
  /// Indicates that the marked attribute is used for attribute routing in ASP.NET
  /// </summary>
  /// <remarks>
  /// IDE will analyze all usages of attributes marked with this attribute,
  /// and will add all routes to completion, navigation and other features over URI strings
  /// </remarks>
  [AttributeUsage(AttributeTargets.Class)]
  public sealed class AspAttributeRoutingAttribute : Attribute
  {
    public string HttpVerb { get; set; }
  }

  /// <summary>
  /// Indicates that the marked method declares ASP.NET Minimal API endpoint
  /// </summary>
  /// <remarks>
  /// IDE will analyze all usages of methods marked with this attribute,
  /// and will add all routes to completion, navigation and other features over URI strings
  /// </remarks>
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class AspMinimalApiDeclarationAttribute : Attribute
  {
    public string HttpVerb { get; set; }
  }

  /// <summary>
  /// Indicates that the marked parameter contains ASP.NET Minimal API endpoint handler
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class AspMinimalApiHandlerAttribute : Attribute { }

  #endregion

  #region Razor

  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.Field)]
  public sealed class HtmlElementAttributesAttribute : Attribute
  {
    public HtmlElementAttributesAttribute() { }

    public HtmlElementAttributesAttribute([NotNull] string name)
    {
      Name = name;
    }

    [CanBeNull] public string Name { get; }
  }

  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class HtmlAttributeValueAttribute : Attribute
  {
    public HtmlAttributeValueAttribute([NotNull] string name)
    {
      Name = name;
    }

    [NotNull] public string Name { get; }
  }

  /// <summary>
  /// Razor attribute. Indicates that the marked parameter or method is a Razor section.
  /// Use this attribute for custom wrappers similar to
  /// <c>System.Web.WebPages.WebPageBase.RenderSection(String)</c>.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method)]
  public sealed class RazorSectionAttribute : Attribute { }

  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorImportNamespaceAttribute : Attribute
  {
    public RazorImportNamespaceAttribute([NotNull] string name)
    {
      Name = name;
    }

    [NotNull] public string Name { get; }
  }

  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorInjectionAttribute : Attribute
  {
    public RazorInjectionAttribute([NotNull] string type, [NotNull] string fieldName)
    {
      Type = type;
      FieldName = fieldName;
    }

    [NotNull] public string Type { get; }

    [NotNull] public string FieldName { get; }
  }

  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorDirectiveAttribute : Attribute
  {
    public RazorDirectiveAttribute([NotNull] string directive)
    {
      Directive = directive;
    }

    [NotNull] public string Directive { get; }
  }
After:
    [NotNull]
        public string ConstraintName { get; }

    [CanBeNull]
        public Type ProposedType { get; set; }
  }

  /// <summary>
  /// Indicates that the marked parameter, field, or property is an URI string.
  /// </summary>
  /// <remarks>
  /// This attribute enables code completion, navigation, rename and other features
  /// in URI string literals assigned to annotated parameter, field or property.
  /// </remarks>
*/
  {
        public RouteParameterConstraintAttribute([NotNull] string constraintName)
        {
            this.ConstraintName = constraintName;
        }

        [NotNull]
        public string ConstraintName { get; }

        [CanBeNull]
        public Type ProposedType { get; set; }
    }

    /// <summary>
    /// Indicates that the marked parameter, field, or property is an URI string.
    /// </summary>
    /// <remarks>
    /// This attribute enables code completion, navigation, rename and other features
    /// in URI string literals assigned to annotated parameter, field or property.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class UriStringAttribute : Attribute
    {
        public UriStringAttribute()
        {
        }

        public UriStringAttribute(string httpVerb)
        {
            this.HttpVerb = httpVerb;
        }

        [CanBeNull]
        public string HttpVerb { get; }
    }

    /// <summary>
    /// Indicates that the marked method declares routing convention for ASP.NET.
    /// </summary>
    /// <remarks>
    /// IDE will analyze all usages of methods marked with this attribute,
    /// and will add all routes to completion, navigation and other features over URI strings.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class AspRouteConventionAttribute : Attribute
    {
        public AspRouteConventionAttribute()
        {
        }

        public AspRouteConventionAttribute(string predefinedPattern)
        {
            this.PredefinedPattern = predefinedPattern;
        }

        [CanBeNull]
        public string PredefinedPattern { get; }
    }

    /// <summary>
    /// Indicates that the marked method parameter contains default route values of routing convention for ASP.NET.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class AspDefaultRouteValuesAttribute : Attribute
    {
    }

    /// <summary>
    /// Indicates that the marked method parameter contains constraints on route values of routing convention for ASP.NET.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class AspRouteValuesConstraintsAttribute : Attribute
    {
    }

    /// <summary>
    /// Indicates that the marked parameter or property contains routing order provided by ASP.NET routing attribute.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
    public sealed class AspRouteOrderAttribute : Attribute
    {
    }

    /// <summary>
    /// Indicates that the marked parameter or property contains HTTP verbs provided by ASP.NET routing attribute.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
    public sealed class AspRouteVerbsAttribute : Attribute
    {
    }

    /// <summary>
    /// Indicates that the marked attribute is used for attribute routing in ASP.NET.
    /// </summary>
    /// <remarks>
    /// IDE will analyze all usages of attributes marked with this attribute,
    /// and will add all routes to completion, navigation and other features over URI strings.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class AspAttributeRoutingAttribute : Attribute
    {
        public string HttpVerb { get; set; }
    }

    /// <summary>
    /// Indicates that the marked method declares ASP.NET Minimal API endpoint.
    /// </summary>
    /// <remarks>
    /// IDE will analyze all usages of methods marked with this attribute,
    /// and will add all routes to completion, navigation and other features over URI strings.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class AspMinimalApiDeclarationAttribute : Attribute
    {
        public string HttpVerb { get; set; }
    }

    /// <summary>
    /// Indicates that the marked parameter contains ASP.NET Minimal API endpoint handler.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class AspMinimalApiHandlerAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.Field)]
    public sealed class HtmlElementAttributesAttribute : Attribute
    {
        public HtmlElementAttributesAttribute()
        {
        }

        public HtmlElementAttributesAttribute([NotNull] string name)
        {
            this.Name = name;
        }

        [CanBeNull]
        public string Name { get; }
    }

    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class HtmlAttributeValueAttribute : Attribute
    {
        public HtmlAttributeValueAttribute([NotNull] string name)
        {
            this.Name = name;
        }

        [NotNull]
        public string Name { get; }
    }

    /// <summary>
    /// Razor attribute. Indicates that the marked parameter or method is a Razor section.
    /// Use this attribute for custom wrappers similar to
    /// <c>System.Web.WebPages.WebPageBase.RenderSection(String)</c>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method)]
    public sealed class RazorSectionAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public sealed class RazorImportNamespaceAttribute : Attribute
    {
        public RazorImportNamespaceAttribute([NotNull] string name)
        {
            this.Name = name;
        }

        [NotNull]
        public string Name { get; }
    }

    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public sealed class RazorInjectionAttribute : Attribute
    {
        public RazorInjectionAttribute([NotNull] string type, [NotNull] string fieldName)
        {
            this.Type = type;
            this.FieldName = fieldName;
        }

        [NotNull]
        public string Type { get; }

        [NotNull]
        public string FieldName { get; }
    }

    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public sealed class RazorDirectiveAttribute : Attribute
    {
        public RazorDirectiveAttribute([NotNull] string directive)
        {
            this.Directive = directive;
        }

        [NotNull]
        public string Directive { get; }
    }

    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class UriStringAttribute : Attribute
    {
      public UriStringAttribute()

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
      {
        BaseType = baseType;
      }
      public RazorPageBaseTypeAttribute([NotNull] string baseType, string pageName)
      {
          BaseType = baseType;
          PageName = pageName;
      }

      [NotNull] public string BaseType { get; }
      [CanBeNull] public string PageName { get; }
  }

  [AttributeUsage(AttributeTargets.Method)]
  public sealed class RazorHelperCommonAttribute : Attribute { }

  [AttributeUsage(AttributeTargets.Property)]
  public sealed class RazorLayoutAttribute : Attribute { }

  [AttributeUsage(AttributeTargets.Method)]
  public sealed class RazorWriteLiteralMethodAttribute : Attribute { }

  [AttributeUsage(AttributeTargets.Method)]
  public sealed class RazorWriteMethodAttribute : Attribute { }

  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class RazorWriteMethodParameterAttribute : Attribute { }

  #endregion

  #region XAML

  /// <summary>
  /// XAML attribute. Indicates the type that has <c>ItemsSource</c> property and should be treated
  /// as <c>ItemsControl</c>-derived type, to enable inner items <c>DataContext</c> type resolve.
  /// </summary>
  [AttributeUsage(AttributeTargets.Class)]
  public sealed class XamlItemsControlAttribute : Attribute { }

  /// <summary>
  /// XAML attribute. Indicates the property of some <c>BindingBase</c>-derived type, that
  /// is used to bind some item of <c>ItemsControl</c>-derived type. This annotation will
  /// enable the <c>DataContext</c> type resolve for XAML bindings for such properties.
  /// </summary>
  /// <remarks>
  /// Property should have the tree ancestor of the <c>ItemsControl</c> type or
  /// marked with the <see cref="XamlItemsControlAttribute"/> attribute.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Property)]
  public sealed class XamlItemBindingOfItemsControlAttribute : Attribute { }

  /// <summary>
  /// XAML attribute. Indicates the property of some <c>Style</c>-derived type, that
  /// is used to style items of <c>ItemsControl</c>-derived type. This annotation will
  /// enable the <c>DataContext</c> type resolve for XAML bindings for such properties.
  /// </summary>
  /// <remarks>
  /// Property should have the tree ancestor of the <c>ItemsControl</c> type or
  /// marked with the <see cref="XamlItemsControlAttribute"/> attribute.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Property)]
  public sealed class XamlItemStyleOfItemsControlAttribute : Attribute { }

  /// <summary>
  /// XAML attribute. Indicates that DependencyProperty has <c>OneWay</c> binding mode by default.
  /// </summary>
  /// <remarks>
  /// This attribute must be applied to DependencyProperty's CLR accessor property if it is present, to DependencyProperty descriptor field otherwise.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class XamlOneWayBindingModeByDefaultAttribute : Attribute { }

  /// <summary>
  /// XAML attribute. Indicates that DependencyProperty has <c>TwoWay</c> binding mode by default.
  /// </summary>
  /// <remarks>
  /// This attribute must be applied to DependencyProperty's CLR accessor property if it is present, to DependencyProperty descriptor field otherwise.
After:
    {
    }

    public UriStringAttribute([NotNull] string baseType, string pageName)
    {
      this.HttpVerb = baseType;
    }

    [CanBeNull]
        public string HttpVerb { get; }
  }

  /// <summary>
  /// Indicates that the marked method declares routing convention for ASP.NET.
  /// </summary>
  /// <remarks>
  /// IDE will analyze all usages of methods marked with this attribute,
  /// and will add all routes to completion, navigation and other features over URI strings.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
      {
        BaseType = baseType;
      }
      public RazorPageBaseTypeAttribute([NotNull] string baseType, string pageName)
      {
          BaseType = baseType;
          PageName = pageName;
      }

      [NotNull] public string BaseType { get; }
      [CanBeNull] public string PageName { get; }
  }

  [AttributeUsage(AttributeTargets.Method)]
  public sealed class RazorHelperCommonAttribute : Attribute { }

  [AttributeUsage(AttributeTargets.Property)]
  public sealed class RazorLayoutAttribute : Attribute { }

  [AttributeUsage(AttributeTargets.Method)]
  public sealed class RazorWriteLiteralMethodAttribute : Attribute { }

  [AttributeUsage(AttributeTargets.Method)]
  public sealed class RazorWriteMethodAttribute : Attribute { }

  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class RazorWriteMethodParameterAttribute : Attribute { }

  #endregion

  #region XAML

  /// <summary>
  /// XAML attribute. Indicates the type that has <c>ItemsSource</c> property and should be treated
  /// as <c>ItemsControl</c>-derived type, to enable inner items <c>DataContext</c> type resolve.
  /// </summary>
  [AttributeUsage(AttributeTargets.Class)]
  public sealed class XamlItemsControlAttribute : Attribute { }

  /// <summary>
  /// XAML attribute. Indicates the property of some <c>BindingBase</c>-derived type, that
  /// is used to bind some item of <c>ItemsControl</c>-derived type. This annotation will
  /// enable the <c>DataContext</c> type resolve for XAML bindings for such properties.
  /// </summary>
  /// <remarks>
  /// Property should have the tree ancestor of the <c>ItemsControl</c> type or
  /// marked with the <see cref="XamlItemsControlAttribute"/> attribute.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Property)]
  public sealed class XamlItemBindingOfItemsControlAttribute : Attribute { }

  /// <summary>
  /// XAML attribute. Indicates the property of some <c>Style</c>-derived type, that
  /// is used to style items of <c>ItemsControl</c>-derived type. This annotation will
  /// enable the <c>DataContext</c> type resolve for XAML bindings for such properties.
  /// </summary>
  /// <remarks>
  /// Property should have the tree ancestor of the <c>ItemsControl</c> type or
  /// marked with the <see cref="XamlItemsControlAttribute"/> attribute.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Property)]
  public sealed class XamlItemStyleOfItemsControlAttribute : Attribute { }

  /// <summary>
  /// XAML attribute. Indicates that DependencyProperty has <c>OneWay</c> binding mode by default.
  /// </summary>
  /// <remarks>
  /// This attribute must be applied to DependencyProperty's CLR accessor property if it is present, to DependencyProperty descriptor field otherwise.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class XamlOneWayBindingModeByDefaultAttribute : Attribute { }

  /// <summary>
  /// XAML attribute. Indicates that DependencyProperty has <c>TwoWay</c> binding mode by default.
  /// </summary>
  /// <remarks>
  /// This attribute must be applied to DependencyProperty's CLR accessor property if it is present, to DependencyProperty descriptor field otherwise.
After:
    {
    }

    public UriStringAttribute([NotNull] string baseType, string pageName)
    {
      this.HttpVerb = baseType;
    }

    [CanBeNull]
        public string HttpVerb { get; }
  }

  /// <summary>
  /// Indicates that the marked method declares routing convention for ASP.NET.
  /// </summary>
  /// <remarks>
  /// IDE will analyze all usages of methods marked with this attribute,
  /// and will add all routes to completion, navigation and other features over URI strings.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
      {
        BaseType = baseType;
      }
      public RazorPageBaseTypeAttribute([NotNull] string baseType, string pageName)
      {
          BaseType = baseType;
          PageName = pageName;
      }

      [NotNull] public string BaseType { get; }
      [CanBeNull] public string PageName { get; }
  }

  [AttributeUsage(AttributeTargets.Method)]
  public sealed class RazorHelperCommonAttribute : Attribute { }

  [AttributeUsage(AttributeTargets.Property)]
  public sealed class RazorLayoutAttribute : Attribute { }

  [AttributeUsage(AttributeTargets.Method)]
  public sealed class RazorWriteLiteralMethodAttribute : Attribute { }

  [AttributeUsage(AttributeTargets.Method)]
  public sealed class RazorWriteMethodAttribute : Attribute { }

  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class RazorWriteMethodParameterAttribute : Attribute { }

  #endregion

  #region XAML

  /// <summary>
  /// XAML attribute. Indicates the type that has <c>ItemsSource</c> property and should be treated
  /// as <c>ItemsControl</c>-derived type, to enable inner items <c>DataContext</c> type resolve.
  /// </summary>
  [AttributeUsage(AttributeTargets.Class)]
  public sealed class XamlItemsControlAttribute : Attribute { }

  /// <summary>
  /// XAML attribute. Indicates the property of some <c>BindingBase</c>-derived type, that
  /// is used to bind some item of <c>ItemsControl</c>-derived type. This annotation will
  /// enable the <c>DataContext</c> type resolve for XAML bindings for such properties.
  /// </summary>
  /// <remarks>
  /// Property should have the tree ancestor of the <c>ItemsControl</c> type or
  /// marked with the <see cref="XamlItemsControlAttribute"/> attribute.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Property)]
  public sealed class XamlItemBindingOfItemsControlAttribute : Attribute { }

  /// <summary>
  /// XAML attribute. Indicates the property of some <c>Style</c>-derived type, that
  /// is used to style items of <c>ItemsControl</c>-derived type. This annotation will
  /// enable the <c>DataContext</c> type resolve for XAML bindings for such properties.
  /// </summary>
  /// <remarks>
  /// Property should have the tree ancestor of the <c>ItemsControl</c> type or
  /// marked with the <see cref="XamlItemsControlAttribute"/> attribute.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Property)]
  public sealed class XamlItemStyleOfItemsControlAttribute : Attribute { }

  /// <summary>
  /// XAML attribute. Indicates that DependencyProperty has <c>OneWay</c> binding mode by default.
  /// </summary>
  /// <remarks>
  /// This attribute must be applied to DependencyProperty's CLR accessor property if it is present, to DependencyProperty descriptor field otherwise.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class XamlOneWayBindingModeByDefaultAttribute : Attribute { }

  /// <summary>
  /// XAML attribute. Indicates that DependencyProperty has <c>TwoWay</c> binding mode by default.
  /// </summary>
  /// <remarks>
  /// This attribute must be applied to DependencyProperty's CLR accessor property if it is present, to DependencyProperty descriptor field otherwise.
After:
    {
    }

    public UriStringAttribute([NotNull] string baseType, string pageName)
    {
      this.HttpVerb = baseType;
    }

    [CanBeNull]
        public string HttpVerb { get; }
  }

  /// <summary>
  /// Indicates that the marked method declares routing convention for ASP.NET.
  /// </summary>
  /// <remarks>
  /// IDE will analyze all usages of methods marked with this attribute,
  /// and will add all routes to completion, navigation and other features over URI strings.
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
      {
        BaseType = baseType;
      }
      public RazorPageBaseTypeAttribute([NotNull] string baseType, string pageName)
      {
          BaseType = baseType;
          PageName = pageName;
      }

      [NotNull] public string BaseType { get; }
      [CanBeNull] public string PageName { get; }
  }

  [AttributeUsage(AttributeTargets.Method)]
  public sealed class RazorHelperCommonAttribute : Attribute { }

  [AttributeUsage(AttributeTargets.Property)]
  public sealed class RazorLayoutAttribute : Attribute { }

  [AttributeUsage(AttributeTargets.Method)]
  public sealed class RazorWriteLiteralMethodAttribute : Attribute { }

  [AttributeUsage(AttributeTargets.Method)]
  public sealed class RazorWriteMethodAttribute : Attribute { }

  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class RazorWriteMethodParameterAttribute : Attribute { }

  #endregion

  #region XAML

  /// <summary>
  /// XAML attribute. Indicates the type that has <c>ItemsSource</c> property and should be treated
  /// as <c>ItemsControl</c>-derived type, to enable inner items <c>DataContext</c> type resolve.
  /// </summary>
  [AttributeUsage(AttributeTargets.Class)]
  public sealed class XamlItemsControlAttribute : Attribute { }

  /// <summary>
  /// XAML attribute. Indicates the property of some <c>BindingBase</c>-derived type, that
  /// is used to bind some item of <c>ItemsControl</c>-derived type. This annotation will
  /// enable the <c>DataContext</c> type resolve for XAML bindings for such properties.
  /// </summary>
  /// <remarks>
  /// Property should have the tree ancestor of the <c>ItemsControl</c> type or
  /// marked with the <see cref="XamlItemsControlAttribute"/> attribute.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Property)]
  public sealed class XamlItemBindingOfItemsControlAttribute : Attribute { }

  /// <summary>
  /// XAML attribute. Indicates the property of some <c>Style</c>-derived type, that
  /// is used to style items of <c>ItemsControl</c>-derived type. This annotation will
  /// enable the <c>DataContext</c> type resolve for XAML bindings for such properties.
  /// </summary>
  /// <remarks>
  /// Property should have the tree ancestor of the <c>ItemsControl</c> type or
  /// marked with the <see cref="XamlItemsControlAttribute"/> attribute.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Property)]
  public sealed class XamlItemStyleOfItemsControlAttribute : Attribute { }

  /// <summary>
  /// XAML attribute. Indicates that DependencyProperty has <c>OneWay</c> binding mode by default.
  /// </summary>
  /// <remarks>
  /// This attribute must be applied to DependencyProperty's CLR accessor property if it is present, to DependencyProperty descriptor field otherwise.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class XamlOneWayBindingModeByDefaultAttribute : Attribute { }

  /// <summary>
  /// XAML attribute. Indicates that DependencyProperty has <c>TwoWay</c> binding mode by default.
  /// </summary>
  /// <remarks>
  /// This attribute must be applied to DependencyProperty's CLR accessor property if it is present, to DependencyProperty descriptor field otherwise.
After:
    {
    }

    public UriStringAttribute([NotNull] string baseType, string pageName)
    {
      this.HttpVerb = baseType;
    }

    [CanBeNull]
        public string HttpVerb { get; }
  }

  /// <summary>
  /// Indicates that the marked method declares routing convention for ASP.NET.
  /// </summary>
  /// <remarks>
  /// IDE will analyze all usages of methods marked with this attribute,
  /// and will add all routes to completion, navigation and other features over URI strings.
*/
        {
            this.BaseType = baseType;
        }

        public RazorPageBaseTypeAttribute(string httpVerb)
        {
            this.BaseType = httpVerb;
            this.PageName = pageName;
        }

        [NotNull]
        public string BaseType { get; }

        [CanBeNull]
        public string PageName { get; }
    }

    [AttributeUsage(AttributeTargets.Method)]
    public sealed class RazorHelperCommonAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property)]
    public sealed class RazorLayoutAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Method)]
    public sealed class RazorWriteLiteralMethodAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Method)]
    public sealed class RazorWriteMethodAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class RazorWriteMethodParameterAttribute : Attribute
    {
    }



    /// <summary>
    /// XAML attribute. Indicates the type that has <c>ItemsSource</c> property and should be treated
    /// as <c>ItemsControl</c>-derived type, to enable inner items <c>DataContext</c> type resolve.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class XamlItemsControlAttribute : Attribute
    {
    }

    /// <summary>
    /// XAML attribute. Indicates the property of some <c>BindingBase</c>-derived type, that
    /// is used to bind some item of <c>ItemsControl</c>-derived type. This annotation will
    /// enable the <c>DataContext</c> type resolve for XAML bindings for such properties.
    /// </summary>
    /// <remarks>
    /// Property should have the tree ancestor of the <c>ItemsControl</c> type or
    /// marked with the <see cref="XamlItemsControlAttribute"/> attribute.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class XamlItemBindingOfItemsControlAttribute : Attribute
    {
    }

    /// <summary>
    /// XAML attribute. Indicates the property of some <c>Style</c>-derived type, that
    /// is used to style items of <c>ItemsControl</c>-derived type. This annotation will
    /// enable the <c>DataContext</c> type resolve for XAML bindings for such properties.
    /// </summary>
    /// <remarks>
    /// Property should have the tree ancestor of the <c>ItemsControl</c> type or
    /// marked with the <see cref="XamlItemsControlAttribute"/> attribute.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class XamlItemStyleOfItemsControlAttribute : Attribute
    {
    }

    /// <summary>
    /// XAML attribute. Indicates that DependencyProperty has <c>OneWay</c> binding mode by default.
    /// </summary>
    /// <remarks>
    /// This attribute must be applied to DependencyProperty's CLR accessor property if it is present, to DependencyProperty descriptor field otherwise.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class XamlOneWayBindingModeByDefaultAttribute : Attribute
    {
    }

    /// <summary>
    /// XAML attribute. Indicates that DependencyProperty has <c>TwoWay</c> binding mode by default.
    /// </summary>
    /// <remarks>
    /// This attribute must be applied to DependencyProperty's CLR accessor property if it is present, to DependencyProperty descriptor field otherwise.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Method)]
  public sealed class AspRouteConventionAttribute : Attribute
  {
    public AspRouteConventionAttribute()
    {
    }

    public AspRouteConventionAttribute(string predefinedPattern)
    {
      this.PredefinedPattern = predefinedPattern;
    }

    [CanBeNull]
        public string PredefinedPattern { get; }
  }

  /// <summary>
  /// Indicates that the marked method parameter contains default route values of routing convention for ASP.NET.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter)]

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-android)'
Before:
  public sealed class XamlTwoWayBindingModeByDefaultAttribute : Attribute { }

  #endregion
After:
  public sealed class XamlTwoWayBindingModeByDefaultAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked method parameter contains constraints on route values of routing convention for ASP.NET.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class AspRouteValuesConstraintsAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked parameter or property contains routing order provided by ASP.NET routing attribute.
  /// </summary>
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
  public sealed class AspRouteOrderAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked parameter or property contains HTTP verbs provided by ASP.NET routing attribute.
  /// </summary>
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
  public sealed class AspRouteVerbsAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked attribute is used for attribute routing in ASP.NET.
  /// </summary>
  /// <remarks>
  /// IDE will analyze all usages of attributes marked with this attribute,
  /// and will add all routes to completion, navigation and other features over URI strings.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Class)]
  public sealed class AspAttributeRoutingAttribute : Attribute
  {
    public string HttpVerb { get; set; }
  }

  /// <summary>
  /// Indicates that the marked method declares ASP.NET Minimal API endpoint.
  /// </summary>
  /// <remarks>
  /// IDE will analyze all usages of methods marked with this attribute,
  /// and will add all routes to completion, navigation and other features over URI strings.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class AspMinimalApiDeclarationAttribute : Attribute
  {
    public string HttpVerb { get; set; }
  }

  /// <summary>
  /// Indicates that the marked parameter contains ASP.NET Minimal API endpoint handler.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class AspMinimalApiHandlerAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.Field)]
  public sealed class HtmlElementAttributesAttribute : Attribute
  {
    public HtmlElementAttributesAttribute()
    {
    }

    public HtmlElementAttributesAttribute([NotNull] string name)
    {
      this.Name = name;
    }

    [CanBeNull]
        public string Name { get; }
  }

  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class HtmlAttributeValueAttribute : Attribute
  {
    public HtmlAttributeValueAttribute([NotNull] string name)
    {
      this.Name = name;
    }

    [NotNull]
        public string Name { get; }
  }

  /// <summary>
  /// Razor attribute. Indicates that the marked parameter or method is a Razor section.
  /// Use this attribute for custom wrappers similar to
  /// <c>System.Web.WebPages.WebPageBase.RenderSection(String)</c>.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method)]
  public sealed class RazorSectionAttribute : Attribute
    {
    }

  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorImportNamespaceAttribute : Attribute
  {
    public RazorImportNamespaceAttribute([NotNull] string name)
    {
      this.Name = name;
    }

    [NotNull]
        public string Name { get; }
  }

  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorInjectionAttribute : Attribute
  {
    public RazorInjectionAttribute([NotNull] string type, [NotNull] string fieldName)
    {
      this.Type = type;
      this.FieldName = fieldName;
    }

    [NotNull]
        public string Type { get; }

    [NotNull]
        public string FieldName { get; }
  }

  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorDirectiveAttribute : Attribute
  {
    public RazorDirectiveAttribute([NotNull] string directive)
    {
      this.Directive = directive;
    }

    [NotNull]
        public string Directive { get; }
  }

  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorPageBaseTypeAttribute : Attribute
  {
      public RazorPageBaseTypeAttribute([NotNull] string baseType)
      {
        this.BaseType = baseType;
      }

      public RazorPageBaseTypeAttribute([NotNull] string baseType, string pageName)
      {
          this.BaseType = baseType;
          this.PageName = pageName;
      }

      [NotNull]
        public string BaseType { get; }

      [CanBeNull]
        public string PageName { get; }
  }

  [AttributeUsage(AttributeTargets.Method)]
  public sealed class RazorHelperCommonAttribute : Attribute
    {
    }

  [AttributeUsage(AttributeTargets.Property)]
  public sealed class RazorLayoutAttribute : Attribute
    {
    }

  [AttributeUsage(AttributeTargets.Method)]
  public sealed class RazorWriteLiteralMethodAttribute : Attribute
    {
    }

  [AttributeUsage(AttributeTargets.Method)]
  public sealed class RazorWriteMethodAttribute : Attribute
    {
    }

  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class RazorWriteMethodParameterAttribute : Attribute
    {
    }



    /// <summary>
    /// XAML attribute. Indicates the type that has <c>ItemsSource</c> property and should be treated
    /// as <c>ItemsControl</c>-derived type, to enable inner items <c>DataContext</c> type resolve.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
  public sealed class XamlItemsControlAttribute : Attribute
    {
    }

  /// <summary>
  /// XAML attribute. Indicates the property of some <c>BindingBase</c>-derived type, that
  /// is used to bind some item of <c>ItemsControl</c>-derived type. This annotation will
  /// enable the <c>DataContext</c> type resolve for XAML bindings for such properties.
  /// </summary>
  /// <remarks>
  /// Property should have the tree ancestor of the <c>ItemsControl</c> type or
  /// marked with the <see cref="XamlItemsControlAttribute"/> attribute.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Property)]
  public sealed class XamlItemBindingOfItemsControlAttribute : Attribute
    {
    }

  /// <summary>
  /// XAML attribute. Indicates the property of some <c>Style</c>-derived type, that
  /// is used to style items of <c>ItemsControl</c>-derived type. This annotation will
  /// enable the <c>DataContext</c> type resolve for XAML bindings for such properties.
  /// </summary>
  /// <remarks>
  /// Property should have the tree ancestor of the <c>ItemsControl</c> type or
  /// marked with the <see cref="XamlItemsControlAttribute"/> attribute.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Property)]
  public sealed class XamlItemStyleOfItemsControlAttribute : Attribute
    {
    }

  /// <summary>
  /// XAML attribute. Indicates that DependencyProperty has <c>OneWay</c> binding mode by default.
  /// </summary>
  /// <remarks>
  /// This attribute must be applied to DependencyProperty's CLR accessor property if it is present, to DependencyProperty descriptor field otherwise.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class XamlOneWayBindingModeByDefaultAttribute : Attribute
    {
    }

  /// <summary>
  /// XAML attribute. Indicates that DependencyProperty has <c>TwoWay</c> binding mode by default.
  /// </summary>
  /// <remarks>
  /// This attribute must be applied to DependencyProperty's CLR accessor property if it is present, to DependencyProperty descriptor field otherwise.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class XamlTwoWayBindingModeByDefaultAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-ios)'
Before:
  public sealed class XamlTwoWayBindingModeByDefaultAttribute : Attribute { }

  #endregion
After:
  public sealed class XamlTwoWayBindingModeByDefaultAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked method parameter contains constraints on route values of routing convention for ASP.NET.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class AspRouteValuesConstraintsAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked parameter or property contains routing order provided by ASP.NET routing attribute.
  /// </summary>
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
  public sealed class AspRouteOrderAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked parameter or property contains HTTP verbs provided by ASP.NET routing attribute.
  /// </summary>
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
  public sealed class AspRouteVerbsAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked attribute is used for attribute routing in ASP.NET.
  /// </summary>
  /// <remarks>
  /// IDE will analyze all usages of attributes marked with this attribute,
  /// and will add all routes to completion, navigation and other features over URI strings.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Class)]
  public sealed class AspAttributeRoutingAttribute : Attribute
  {
    public string HttpVerb { get; set; }
  }

  /// <summary>
  /// Indicates that the marked method declares ASP.NET Minimal API endpoint.
  /// </summary>
  /// <remarks>
  /// IDE will analyze all usages of methods marked with this attribute,
  /// and will add all routes to completion, navigation and other features over URI strings.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class AspMinimalApiDeclarationAttribute : Attribute
  {
    public string HttpVerb { get; set; }
  }

  /// <summary>
  /// Indicates that the marked parameter contains ASP.NET Minimal API endpoint handler.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class AspMinimalApiHandlerAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.Field)]
  public sealed class HtmlElementAttributesAttribute : Attribute
  {
    public HtmlElementAttributesAttribute()
    {
    }

    public HtmlElementAttributesAttribute([NotNull] string name)
    {
      this.Name = name;
    }

    [CanBeNull]
        public string Name { get; }
  }

  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class HtmlAttributeValueAttribute : Attribute
  {
    public HtmlAttributeValueAttribute([NotNull] string name)
    {
      this.Name = name;
    }

    [NotNull]
        public string Name { get; }
  }

  /// <summary>
  /// Razor attribute. Indicates that the marked parameter or method is a Razor section.
  /// Use this attribute for custom wrappers similar to
  /// <c>System.Web.WebPages.WebPageBase.RenderSection(String)</c>.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method)]
  public sealed class RazorSectionAttribute : Attribute
    {
    }

  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorImportNamespaceAttribute : Attribute
  {
    public RazorImportNamespaceAttribute([NotNull] string name)
    {
      this.Name = name;
    }

    [NotNull]
        public string Name { get; }
  }

  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorInjectionAttribute : Attribute
  {
    public RazorInjectionAttribute([NotNull] string type, [NotNull] string fieldName)
    {
      this.Type = type;
      this.FieldName = fieldName;
    }

    [NotNull]
        public string Type { get; }

    [NotNull]
        public string FieldName { get; }
  }

  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorDirectiveAttribute : Attribute
  {
    public RazorDirectiveAttribute([NotNull] string directive)
    {
      this.Directive = directive;
    }

    [NotNull]
        public string Directive { get; }
  }

  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorPageBaseTypeAttribute : Attribute
  {
      public RazorPageBaseTypeAttribute([NotNull] string baseType)
      {
        this.BaseType = baseType;
      }

      public RazorPageBaseTypeAttribute([NotNull] string baseType, string pageName)
      {
          this.BaseType = baseType;
          this.PageName = pageName;
      }

      [NotNull]
        public string BaseType { get; }

      [CanBeNull]
        public string PageName { get; }
  }

  [AttributeUsage(AttributeTargets.Method)]
  public sealed class RazorHelperCommonAttribute : Attribute
    {
    }

  [AttributeUsage(AttributeTargets.Property)]
  public sealed class RazorLayoutAttribute : Attribute
    {
    }

  [AttributeUsage(AttributeTargets.Method)]
  public sealed class RazorWriteLiteralMethodAttribute : Attribute
    {
    }

  [AttributeUsage(AttributeTargets.Method)]
  public sealed class RazorWriteMethodAttribute : Attribute
    {
    }

  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class RazorWriteMethodParameterAttribute : Attribute
    {
    }



    /// <summary>
    /// XAML attribute. Indicates the type that has <c>ItemsSource</c> property and should be treated
    /// as <c>ItemsControl</c>-derived type, to enable inner items <c>DataContext</c> type resolve.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
  public sealed class XamlItemsControlAttribute : Attribute
    {
    }

  /// <summary>
  /// XAML attribute. Indicates the property of some <c>BindingBase</c>-derived type, that
  /// is used to bind some item of <c>ItemsControl</c>-derived type. This annotation will
  /// enable the <c>DataContext</c> type resolve for XAML bindings for such properties.
  /// </summary>
  /// <remarks>
  /// Property should have the tree ancestor of the <c>ItemsControl</c> type or
  /// marked with the <see cref="XamlItemsControlAttribute"/> attribute.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Property)]
  public sealed class XamlItemBindingOfItemsControlAttribute : Attribute
    {
    }

  /// <summary>
  /// XAML attribute. Indicates the property of some <c>Style</c>-derived type, that
  /// is used to style items of <c>ItemsControl</c>-derived type. This annotation will
  /// enable the <c>DataContext</c> type resolve for XAML bindings for such properties.
  /// </summary>
  /// <remarks>
  /// Property should have the tree ancestor of the <c>ItemsControl</c> type or
  /// marked with the <see cref="XamlItemsControlAttribute"/> attribute.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Property)]
  public sealed class XamlItemStyleOfItemsControlAttribute : Attribute
    {
    }

  /// <summary>
  /// XAML attribute. Indicates that DependencyProperty has <c>OneWay</c> binding mode by default.
  /// </summary>
  /// <remarks>
  /// This attribute must be applied to DependencyProperty's CLR accessor property if it is present, to DependencyProperty descriptor field otherwise.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class XamlOneWayBindingModeByDefaultAttribute : Attribute
    {
    }

  /// <summary>
  /// XAML attribute. Indicates that DependencyProperty has <c>TwoWay</c> binding mode by default.
  /// </summary>
  /// <remarks>
  /// This attribute must be applied to DependencyProperty's CLR accessor property if it is present, to DependencyProperty descriptor field otherwise.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class XamlTwoWayBindingModeByDefaultAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-maccatalyst)'
Before:
  public sealed class XamlTwoWayBindingModeByDefaultAttribute : Attribute { }

  #endregion
After:
  public sealed class XamlTwoWayBindingModeByDefaultAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked method parameter contains constraints on route values of routing convention for ASP.NET.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class AspRouteValuesConstraintsAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked parameter or property contains routing order provided by ASP.NET routing attribute.
  /// </summary>
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
  public sealed class AspRouteOrderAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked parameter or property contains HTTP verbs provided by ASP.NET routing attribute.
  /// </summary>
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
  public sealed class AspRouteVerbsAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked attribute is used for attribute routing in ASP.NET.
  /// </summary>
  /// <remarks>
  /// IDE will analyze all usages of attributes marked with this attribute,
  /// and will add all routes to completion, navigation and other features over URI strings.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Class)]
  public sealed class AspAttributeRoutingAttribute : Attribute
  {
    public string HttpVerb { get; set; }
  }

  /// <summary>
  /// Indicates that the marked method declares ASP.NET Minimal API endpoint.
  /// </summary>
  /// <remarks>
  /// IDE will analyze all usages of methods marked with this attribute,
  /// and will add all routes to completion, navigation and other features over URI strings.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class AspMinimalApiDeclarationAttribute : Attribute
  {
    public string HttpVerb { get; set; }
  }

  /// <summary>
  /// Indicates that the marked parameter contains ASP.NET Minimal API endpoint handler.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class AspMinimalApiHandlerAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.Field)]
  public sealed class HtmlElementAttributesAttribute : Attribute
  {
    public HtmlElementAttributesAttribute()
    {
    }

    public HtmlElementAttributesAttribute([NotNull] string name)
    {
      this.Name = name;
    }

    [CanBeNull]
        public string Name { get; }
  }

  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class HtmlAttributeValueAttribute : Attribute
  {
    public HtmlAttributeValueAttribute([NotNull] string name)
    {
      this.Name = name;
    }

    [NotNull]
        public string Name { get; }
  }

  /// <summary>
  /// Razor attribute. Indicates that the marked parameter or method is a Razor section.
  /// Use this attribute for custom wrappers similar to
  /// <c>System.Web.WebPages.WebPageBase.RenderSection(String)</c>.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method)]
  public sealed class RazorSectionAttribute : Attribute
    {
    }

  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorImportNamespaceAttribute : Attribute
  {
    public RazorImportNamespaceAttribute([NotNull] string name)
    {
      this.Name = name;
    }

    [NotNull]
        public string Name { get; }
  }

  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorInjectionAttribute : Attribute
  {
    public RazorInjectionAttribute([NotNull] string type, [NotNull] string fieldName)
    {
      this.Type = type;
      this.FieldName = fieldName;
    }

    [NotNull]
        public string Type { get; }

    [NotNull]
        public string FieldName { get; }
  }

  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorDirectiveAttribute : Attribute
  {
    public RazorDirectiveAttribute([NotNull] string directive)
    {
      this.Directive = directive;
    }

    [NotNull]
        public string Directive { get; }
  }

  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorPageBaseTypeAttribute : Attribute
  {
      public RazorPageBaseTypeAttribute([NotNull] string baseType)
      {
        this.BaseType = baseType;
      }

      public RazorPageBaseTypeAttribute([NotNull] string baseType, string pageName)
      {
          this.BaseType = baseType;
          this.PageName = pageName;
      }

      [NotNull]
        public string BaseType { get; }

      [CanBeNull]
        public string PageName { get; }
  }

  [AttributeUsage(AttributeTargets.Method)]
  public sealed class RazorHelperCommonAttribute : Attribute
    {
    }

  [AttributeUsage(AttributeTargets.Property)]
  public sealed class RazorLayoutAttribute : Attribute
    {
    }

  [AttributeUsage(AttributeTargets.Method)]
  public sealed class RazorWriteLiteralMethodAttribute : Attribute
    {
    }

  [AttributeUsage(AttributeTargets.Method)]
  public sealed class RazorWriteMethodAttribute : Attribute
    {
    }

  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class RazorWriteMethodParameterAttribute : Attribute
    {
    }



    /// <summary>
    /// XAML attribute. Indicates the type that has <c>ItemsSource</c> property and should be treated
    /// as <c>ItemsControl</c>-derived type, to enable inner items <c>DataContext</c> type resolve.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
  public sealed class XamlItemsControlAttribute : Attribute
    {
    }

  /// <summary>
  /// XAML attribute. Indicates the property of some <c>BindingBase</c>-derived type, that
  /// is used to bind some item of <c>ItemsControl</c>-derived type. This annotation will
  /// enable the <c>DataContext</c> type resolve for XAML bindings for such properties.
  /// </summary>
  /// <remarks>
  /// Property should have the tree ancestor of the <c>ItemsControl</c> type or
  /// marked with the <see cref="XamlItemsControlAttribute"/> attribute.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Property)]
  public sealed class XamlItemBindingOfItemsControlAttribute : Attribute
    {
    }

  /// <summary>
  /// XAML attribute. Indicates the property of some <c>Style</c>-derived type, that
  /// is used to style items of <c>ItemsControl</c>-derived type. This annotation will
  /// enable the <c>DataContext</c> type resolve for XAML bindings for such properties.
  /// </summary>
  /// <remarks>
  /// Property should have the tree ancestor of the <c>ItemsControl</c> type or
  /// marked with the <see cref="XamlItemsControlAttribute"/> attribute.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Property)]
  public sealed class XamlItemStyleOfItemsControlAttribute : Attribute
    {
    }

  /// <summary>
  /// XAML attribute. Indicates that DependencyProperty has <c>OneWay</c> binding mode by default.
  /// </summary>
  /// <remarks>
  /// This attribute must be applied to DependencyProperty's CLR accessor property if it is present, to DependencyProperty descriptor field otherwise.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class XamlOneWayBindingModeByDefaultAttribute : Attribute
    {
    }

  /// <summary>
  /// XAML attribute. Indicates that DependencyProperty has <c>TwoWay</c> binding mode by default.
  /// </summary>
  /// <remarks>
  /// This attribute must be applied to DependencyProperty's CLR accessor property if it is present, to DependencyProperty descriptor field otherwise.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class XamlTwoWayBindingModeByDefaultAttribute : Attribute
    {
    }
*/

/* Unmerged change from project 'Nothing.Nauta.App(net6.0-windows10.0.19041.0)'
Before:
  public sealed class XamlTwoWayBindingModeByDefaultAttribute : Attribute { }

  #endregion
After:
  public sealed class XamlTwoWayBindingModeByDefaultAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked method parameter contains constraints on route values of routing convention for ASP.NET.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class AspRouteValuesConstraintsAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked parameter or property contains routing order provided by ASP.NET routing attribute.
  /// </summary>
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
  public sealed class AspRouteOrderAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked parameter or property contains HTTP verbs provided by ASP.NET routing attribute.
  /// </summary>
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
  public sealed class AspRouteVerbsAttribute : Attribute
    {
    }

  /// <summary>
  /// Indicates that the marked attribute is used for attribute routing in ASP.NET.
  /// </summary>
  /// <remarks>
  /// IDE will analyze all usages of attributes marked with this attribute,
  /// and will add all routes to completion, navigation and other features over URI strings.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Class)]
  public sealed class AspAttributeRoutingAttribute : Attribute
  {
    public string HttpVerb { get; set; }
  }

  /// <summary>
  /// Indicates that the marked method declares ASP.NET Minimal API endpoint.
  /// </summary>
  /// <remarks>
  /// IDE will analyze all usages of methods marked with this attribute,
  /// and will add all routes to completion, navigation and other features over URI strings.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class AspMinimalApiDeclarationAttribute : Attribute
  {
    public string HttpVerb { get; set; }
  }

  /// <summary>
  /// Indicates that the marked parameter contains ASP.NET Minimal API endpoint handler.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class AspMinimalApiHandlerAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.Field)]
  public sealed class HtmlElementAttributesAttribute : Attribute
  {
    public HtmlElementAttributesAttribute()
    {
    }

    public HtmlElementAttributesAttribute([NotNull] string name)
    {
      this.Name = name;
    }

    [CanBeNull]
        public string Name { get; }
  }

  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class HtmlAttributeValueAttribute : Attribute
  {
    public HtmlAttributeValueAttribute([NotNull] string name)
    {
      this.Name = name;
    }

    [NotNull]
        public string Name { get; }
  }

  /// <summary>
  /// Razor attribute. Indicates that the marked parameter or method is a Razor section.
  /// Use this attribute for custom wrappers similar to
  /// <c>System.Web.WebPages.WebPageBase.RenderSection(String)</c>.
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Method)]
  public sealed class RazorSectionAttribute : Attribute
    {
    }

  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorImportNamespaceAttribute : Attribute
  {
    public RazorImportNamespaceAttribute([NotNull] string name)
    {
      this.Name = name;
    }

    [NotNull]
        public string Name { get; }
  }

  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorInjectionAttribute : Attribute
  {
    public RazorInjectionAttribute([NotNull] string type, [NotNull] string fieldName)
    {
      this.Type = type;
      this.FieldName = fieldName;
    }

    [NotNull]
        public string Type { get; }

    [NotNull]
        public string FieldName { get; }
  }

  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorDirectiveAttribute : Attribute
  {
    public RazorDirectiveAttribute([NotNull] string directive)
    {
      this.Directive = directive;
    }

    [NotNull]
        public string Directive { get; }
  }

  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorPageBaseTypeAttribute : Attribute
  {
      public RazorPageBaseTypeAttribute([NotNull] string baseType)
      {
        this.BaseType = baseType;
      }

      public RazorPageBaseTypeAttribute([NotNull] string baseType, string pageName)
      {
          this.BaseType = baseType;
          this.PageName = pageName;
      }

      [NotNull]
        public string BaseType { get; }

      [CanBeNull]
        public string PageName { get; }
  }

  [AttributeUsage(AttributeTargets.Method)]
  public sealed class RazorHelperCommonAttribute : Attribute
    {
    }

  [AttributeUsage(AttributeTargets.Property)]
  public sealed class RazorLayoutAttribute : Attribute
    {
    }

  [AttributeUsage(AttributeTargets.Method)]
  public sealed class RazorWriteLiteralMethodAttribute : Attribute
    {
    }

  [AttributeUsage(AttributeTargets.Method)]
  public sealed class RazorWriteMethodAttribute : Attribute
    {
    }

  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class RazorWriteMethodParameterAttribute : Attribute
    {
    }



    /// <summary>
    /// XAML attribute. Indicates the type that has <c>ItemsSource</c> property and should be treated
    /// as <c>ItemsControl</c>-derived type, to enable inner items <c>DataContext</c> type resolve.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
  public sealed class XamlItemsControlAttribute : Attribute
    {
    }

  /// <summary>
  /// XAML attribute. Indicates the property of some <c>BindingBase</c>-derived type, that
  /// is used to bind some item of <c>ItemsControl</c>-derived type. This annotation will
  /// enable the <c>DataContext</c> type resolve for XAML bindings for such properties.
  /// </summary>
  /// <remarks>
  /// Property should have the tree ancestor of the <c>ItemsControl</c> type or
  /// marked with the <see cref="XamlItemsControlAttribute"/> attribute.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Property)]
  public sealed class XamlItemBindingOfItemsControlAttribute : Attribute
    {
    }

  /// <summary>
  /// XAML attribute. Indicates the property of some <c>Style</c>-derived type, that
  /// is used to style items of <c>ItemsControl</c>-derived type. This annotation will
  /// enable the <c>DataContext</c> type resolve for XAML bindings for such properties.
  /// </summary>
  /// <remarks>
  /// Property should have the tree ancestor of the <c>ItemsControl</c> type or
  /// marked with the <see cref="XamlItemsControlAttribute"/> attribute.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Property)]
  public sealed class XamlItemStyleOfItemsControlAttribute : Attribute
    {
    }

  /// <summary>
  /// XAML attribute. Indicates that DependencyProperty has <c>OneWay</c> binding mode by default.
  /// </summary>
  /// <remarks>
  /// This attribute must be applied to DependencyProperty's CLR accessor property if it is present, to DependencyProperty descriptor field otherwise.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class XamlOneWayBindingModeByDefaultAttribute : Attribute
    {
    }

  /// <summary>
  /// XAML attribute. Indicates that DependencyProperty has <c>TwoWay</c> binding mode by default.
  /// </summary>
  /// <remarks>
  /// This attribute must be applied to DependencyProperty's CLR accessor property if it is present, to DependencyProperty descriptor field otherwise.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
  public sealed class XamlTwoWayBindingModeByDefaultAttribute : Attribute
    {
    }
*/
    public sealed class AspDefaultRouteValuesAttribute : Attribute
    {
    }
}