// THIS FILE AUTOMATICALLY GENERATED BY xpidl2cs.pl
// EDITING IS PROBABLY UNWISE
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
// Copyright (c) 2007, 2008 Novell, Inc.
//
// Authors:
//	Andreia Gaita (avidigal@novell.com)
//

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace Mono.Mozilla {

	[Guid ("71a3b4e7-e83d-45cf-a20e-9ce292bcf19f")]
	[InterfaceType (ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport ()]
	internal interface nsIAccessNode {

#region nsIAccessNode
		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getDOMNode ([MarshalAs (UnmanagedType.Interface) ] out nsIDOMNode ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getNumChildren (out int ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getChildNodeAt ( int childNum,
				[MarshalAs (UnmanagedType.Interface) ] out nsIAccessNode ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getParentNode ([MarshalAs (UnmanagedType.Interface) ] out nsIAccessNode ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getFirstChildNode ([MarshalAs (UnmanagedType.Interface) ] out nsIAccessNode ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getLastChildNode ([MarshalAs (UnmanagedType.Interface) ] out nsIAccessNode ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getPreviousSiblingNode ([MarshalAs (UnmanagedType.Interface) ] out nsIAccessNode ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getNextSiblingNode ([MarshalAs (UnmanagedType.Interface) ] out nsIAccessNode ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getAccessibleDocument ([MarshalAs (UnmanagedType.Interface) ] out nsIAccessibleDocument ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getInnerHTML ( /*DOMString*/ HandleRef ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int scrollTo ( uint aScrollType);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int scrollToPoint ( uint aCoordinateType,
				 int aX,
				 int aY);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getOwnerWindow ( IntPtr ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getUniqueID ( IntPtr ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getComputedStyleValue ( /*DOMString*/ HandleRef pseudoElt,
				 /*DOMString*/ HandleRef propertyName,
				 /*DOMString*/ HandleRef ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getComputedStyleCSSValue ( /*DOMString*/ HandleRef pseudoElt,
				 /*DOMString*/ HandleRef propertyName,
				[MarshalAs (UnmanagedType.Interface) ] out nsIDOMCSSPrimitiveValue ret);

		[PreserveSigAttribute]
		[MethodImpl (MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int getLanguage ( /*DOMString*/ HandleRef ret);

#endregion
	}


	internal class nsAccessNode {
		public static nsIAccessNode GetProxy (Mono.WebBrowser.IWebBrowser control, nsIAccessNode obj)
		{
			object o = Base.GetProxyForObject (control, typeof(nsIAccessNode).GUID, obj);
			return o as nsIAccessNode;
		}
	}
}
#if example

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

	internal class AccessNode : nsIAccessNode {

#region nsIAccessNode
		int nsIAccessNode.getDOMNode ([MarshalAs (UnmanagedType.Interface) ] out nsIDOMNode ret)

		{
			return null;
		}

		int nsIAccessNode.getNumChildren (out int ret)

		{
			return 0;
		}

		int nsIAccessNode.getChildNodeAt ( int childNum,
				[MarshalAs (UnmanagedType.Interface) ] out nsIAccessNode ret)
		{
			return ;
		}



		int nsIAccessNode.getParentNode ([MarshalAs (UnmanagedType.Interface) ] out nsIAccessNode ret)

		{
			return null;
		}

		int nsIAccessNode.getFirstChildNode ([MarshalAs (UnmanagedType.Interface) ] out nsIAccessNode ret)

		{
			return null;
		}

		int nsIAccessNode.getLastChildNode ([MarshalAs (UnmanagedType.Interface) ] out nsIAccessNode ret)

		{
			return null;
		}

		int nsIAccessNode.getPreviousSiblingNode ([MarshalAs (UnmanagedType.Interface) ] out nsIAccessNode ret)

		{
			return null;
		}

		int nsIAccessNode.getNextSiblingNode ([MarshalAs (UnmanagedType.Interface) ] out nsIAccessNode ret)

		{
			return null;
		}

		int nsIAccessNode.getAccessibleDocument ([MarshalAs (UnmanagedType.Interface) ] out nsIAccessibleDocument ret)

		{
			return null;
		}

		int nsIAccessNode.getInnerHTML ( /*DOMString*/ HandleRef ret)

		{
			return null;
		}

		int nsIAccessNode.scrollTo ( uint aScrollType)
		{
			return ;
		}



		int nsIAccessNode.scrollToPoint ( uint aCoordinateType,
				 int aX,
				 int aY)
		{
			return ;
		}



		int nsIAccessNode.getOwnerWindow ( IntPtr ret)

		{
			return IntPtr.Zero;
		}

		int nsIAccessNode.getUniqueID ( IntPtr ret)

		{
			return IntPtr.Zero;
		}

		int nsIAccessNode.getComputedStyleValue ( /*DOMString*/ HandleRef pseudoElt,
				 /*DOMString*/ HandleRef propertyName,
				 /*DOMString*/ HandleRef ret)
		{
			return ;
		}



		int nsIAccessNode.getComputedStyleCSSValue ( /*DOMString*/ HandleRef pseudoElt,
				 /*DOMString*/ HandleRef propertyName,
				[MarshalAs (UnmanagedType.Interface) ] out nsIDOMCSSPrimitiveValue ret)
		{
			return ;
		}



		int nsIAccessNode.getLanguage ( /*DOMString*/ HandleRef ret)

		{
			return null;
		}

#endregion
	}
#endif