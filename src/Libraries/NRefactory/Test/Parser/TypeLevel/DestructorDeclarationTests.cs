﻿// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Mike Krüger" email="mike@icsharpcode.net"/>
//     <version>$Revision$</version>
// </file>

using System;
using ICSharpCode.NRefactory.Parser.AST;
using NUnit.Framework;

namespace ICSharpCode.NRefactory.Tests.AST
{
	[TestFixture]
	public class DestructorDeclarationTests
	{
		#region C#
		[Test]
		public void CSharpDestructorDeclarationTest()
		{
			DestructorDeclaration dd = ParseUtilCSharp.ParseTypeMember<DestructorDeclaration>("~MyClass() {}");
		}
		#endregion
		
		#region VB.NET
		// No VB.NET representation
		#endregion 
	}
}
