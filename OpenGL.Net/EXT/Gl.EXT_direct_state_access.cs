
// Copyright (C) 2015-2017 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_PROGRAM_MATRIX_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public const int PROGRAM_MATRIX_EXT = 0x8E2D;

		/// <summary>
		/// Value of GL_TRANSPOSE_PROGRAM_MATRIX_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public const int TRANSPOSE_PROGRAM_MATRIX_EXT = 0x8E2E;

		/// <summary>
		/// Value of GL_PROGRAM_MATRIX_STACK_DEPTH_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public const int PROGRAM_MATRIX_STACK_DEPTH_EXT = 0x8E2F;

		/// <summary>
		/// Binding for glMatrixLoadfEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:MatrixMode"/>.
		/// </param>
		/// <param name="m">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MatrixLoadEXT(MatrixMode mode, float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglMatrixLoadfEXT != null, "pglMatrixLoadfEXT not implemented");
					Delegates.pglMatrixLoadfEXT((Int32)mode, p_m);
					LogFunction("glMatrixLoadfEXT({0}, {1})", mode, LogValue(m));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMatrixLoaddEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:MatrixMode"/>.
		/// </param>
		/// <param name="m">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MatrixLoadEXT(MatrixMode mode, double[] m)
		{
			unsafe {
				fixed (double* p_m = m)
				{
					Debug.Assert(Delegates.pglMatrixLoaddEXT != null, "pglMatrixLoaddEXT not implemented");
					Delegates.pglMatrixLoaddEXT((Int32)mode, p_m);
					LogFunction("glMatrixLoaddEXT({0}, {1})", mode, LogValue(m));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMatrixMultfEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:MatrixMode"/>.
		/// </param>
		/// <param name="m">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MatrixMultEXT(MatrixMode mode, float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglMatrixMultfEXT != null, "pglMatrixMultfEXT not implemented");
					Delegates.pglMatrixMultfEXT((Int32)mode, p_m);
					LogFunction("glMatrixMultfEXT({0}, {1})", mode, LogValue(m));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMatrixMultdEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:MatrixMode"/>.
		/// </param>
		/// <param name="m">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MatrixMultEXT(MatrixMode mode, double[] m)
		{
			unsafe {
				fixed (double* p_m = m)
				{
					Debug.Assert(Delegates.pglMatrixMultdEXT != null, "pglMatrixMultdEXT not implemented");
					Delegates.pglMatrixMultdEXT((Int32)mode, p_m);
					LogFunction("glMatrixMultdEXT({0}, {1})", mode, LogValue(m));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMatrixLoadIdentityEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:MatrixMode"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MatrixLoadIdentityEXT(MatrixMode mode)
		{
			Debug.Assert(Delegates.pglMatrixLoadIdentityEXT != null, "pglMatrixLoadIdentityEXT not implemented");
			Delegates.pglMatrixLoadIdentityEXT((Int32)mode);
			LogFunction("glMatrixLoadIdentityEXT({0})", mode);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMatrixRotatefEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:MatrixMode"/>.
		/// </param>
		/// <param name="angle">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MatrixRotateEXT(MatrixMode mode, float angle, float x, float y, float z)
		{
			Debug.Assert(Delegates.pglMatrixRotatefEXT != null, "pglMatrixRotatefEXT not implemented");
			Delegates.pglMatrixRotatefEXT((Int32)mode, angle, x, y, z);
			LogFunction("glMatrixRotatefEXT({0}, {1}, {2}, {3}, {4})", mode, angle, x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMatrixRotatedEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:MatrixMode"/>.
		/// </param>
		/// <param name="angle">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MatrixRotateEXT(MatrixMode mode, double angle, double x, double y, double z)
		{
			Debug.Assert(Delegates.pglMatrixRotatedEXT != null, "pglMatrixRotatedEXT not implemented");
			Delegates.pglMatrixRotatedEXT((Int32)mode, angle, x, y, z);
			LogFunction("glMatrixRotatedEXT({0}, {1}, {2}, {3}, {4})", mode, angle, x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMatrixScalefEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:MatrixMode"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MatrixScaleEXT(MatrixMode mode, float x, float y, float z)
		{
			Debug.Assert(Delegates.pglMatrixScalefEXT != null, "pglMatrixScalefEXT not implemented");
			Delegates.pglMatrixScalefEXT((Int32)mode, x, y, z);
			LogFunction("glMatrixScalefEXT({0}, {1}, {2}, {3})", mode, x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMatrixScaledEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:MatrixMode"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MatrixScaleEXT(MatrixMode mode, double x, double y, double z)
		{
			Debug.Assert(Delegates.pglMatrixScaledEXT != null, "pglMatrixScaledEXT not implemented");
			Delegates.pglMatrixScaledEXT((Int32)mode, x, y, z);
			LogFunction("glMatrixScaledEXT({0}, {1}, {2}, {3})", mode, x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMatrixTranslatefEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:MatrixMode"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MatrixTranslateEXT(MatrixMode mode, float x, float y, float z)
		{
			Debug.Assert(Delegates.pglMatrixTranslatefEXT != null, "pglMatrixTranslatefEXT not implemented");
			Delegates.pglMatrixTranslatefEXT((Int32)mode, x, y, z);
			LogFunction("glMatrixTranslatefEXT({0}, {1}, {2}, {3})", mode, x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMatrixTranslatedEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:MatrixMode"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MatrixTranslateEXT(MatrixMode mode, double x, double y, double z)
		{
			Debug.Assert(Delegates.pglMatrixTranslatedEXT != null, "pglMatrixTranslatedEXT not implemented");
			Delegates.pglMatrixTranslatedEXT((Int32)mode, x, y, z);
			LogFunction("glMatrixTranslatedEXT({0}, {1}, {2}, {3})", mode, x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMatrixFrustumEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:MatrixMode"/>.
		/// </param>
		/// <param name="left">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="right">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="bottom">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="top">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="zNear">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="zFar">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MatrixFrustumEXT(MatrixMode mode, double left, double right, double bottom, double top, double zNear, double zFar)
		{
			Debug.Assert(Delegates.pglMatrixFrustumEXT != null, "pglMatrixFrustumEXT not implemented");
			Delegates.pglMatrixFrustumEXT((Int32)mode, left, right, bottom, top, zNear, zFar);
			LogFunction("glMatrixFrustumEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", mode, left, right, bottom, top, zNear, zFar);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMatrixOrthoEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:MatrixMode"/>.
		/// </param>
		/// <param name="left">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="right">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="bottom">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="top">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="zNear">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="zFar">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MatrixOrthoEXT(MatrixMode mode, double left, double right, double bottom, double top, double zNear, double zFar)
		{
			Debug.Assert(Delegates.pglMatrixOrthoEXT != null, "pglMatrixOrthoEXT not implemented");
			Delegates.pglMatrixOrthoEXT((Int32)mode, left, right, bottom, top, zNear, zFar);
			LogFunction("glMatrixOrthoEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", mode, left, right, bottom, top, zNear, zFar);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMatrixPopEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:MatrixMode"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MatrixPopEXT(MatrixMode mode)
		{
			Debug.Assert(Delegates.pglMatrixPopEXT != null, "pglMatrixPopEXT not implemented");
			Delegates.pglMatrixPopEXT((Int32)mode);
			LogFunction("glMatrixPopEXT({0})", mode);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMatrixPushEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:MatrixMode"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MatrixPushEXT(MatrixMode mode)
		{
			Debug.Assert(Delegates.pglMatrixPushEXT != null, "pglMatrixPushEXT not implemented");
			Delegates.pglMatrixPushEXT((Int32)mode);
			LogFunction("glMatrixPushEXT({0})", mode);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glClientAttribDefaultEXT.
		/// </summary>
		/// <param name="mask">
		/// A <see cref="T:ClientAttribMask"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void ClientAttribDefaultEXT(ClientAttribMask mask)
		{
			Debug.Assert(Delegates.pglClientAttribDefaultEXT != null, "pglClientAttribDefaultEXT not implemented");
			Delegates.pglClientAttribDefaultEXT((UInt32)mask);
			LogFunction("glClientAttribDefaultEXT({0})", mask);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPushClientAttribDefaultEXT.
		/// </summary>
		/// <param name="mask">
		/// A <see cref="T:ClientAttribMask"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void PushClientAttribDefaultEXT(ClientAttribMask mask)
		{
			Debug.Assert(Delegates.pglPushClientAttribDefaultEXT != null, "pglPushClientAttribDefaultEXT not implemented");
			Delegates.pglPushClientAttribDefaultEXT((UInt32)mask);
			LogFunction("glPushClientAttribDefaultEXT({0})", mask);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureParameterfEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureParameterName"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void TextureParameterEXT(UInt32 texture, TextureTarget target, TextureParameterName pname, float param)
		{
			Debug.Assert(Delegates.pglTextureParameterfEXT != null, "pglTextureParameterfEXT not implemented");
			Delegates.pglTextureParameterfEXT(texture, (Int32)target, (Int32)pname, param);
			LogFunction("glTextureParameterfEXT({0}, {1}, {2}, {3})", texture, target, pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureParameterfvEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void TextureParameterEXT(UInt32 texture, TextureTarget target, TextureParameterName pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglTextureParameterfvEXT != null, "pglTextureParameterfvEXT not implemented");
					Delegates.pglTextureParameterfvEXT(texture, (Int32)target, (Int32)pname, p_params);
					LogFunction("glTextureParameterfvEXT({0}, {1}, {2}, {3})", texture, target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureParameteriEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureParameterName"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void TextureParameterEXT(UInt32 texture, TextureTarget target, TextureParameterName pname, Int32 param)
		{
			Debug.Assert(Delegates.pglTextureParameteriEXT != null, "pglTextureParameteriEXT not implemented");
			Delegates.pglTextureParameteriEXT(texture, (Int32)target, (Int32)pname, param);
			LogFunction("glTextureParameteriEXT({0}, {1}, {2}, {3})", texture, target, pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureParameterivEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void TextureParameterEXT(UInt32 texture, TextureTarget target, TextureParameterName pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTextureParameterivEXT != null, "pglTextureParameterivEXT not implemented");
					Delegates.pglTextureParameterivEXT(texture, (Int32)target, (Int32)pname, p_params);
					LogFunction("glTextureParameterivEXT({0}, {1}, {2}, {3})", texture, target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureImage1DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void TextureImage1DEXT(UInt32 texture, TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTextureImage1DEXT != null, "pglTextureImage1DEXT not implemented");
			Delegates.pglTextureImage1DEXT(texture, (Int32)target, level, internalformat, width, border, (Int32)format, (Int32)type, pixels);
			LogFunction("glTextureImage1DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, 0x{8})", texture, target, level, internalformat, width, border, format, type, pixels.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureImage1DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void TextureImage1DEXT(UInt32 texture, TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 border, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TextureImage1DEXT(texture, target, level, internalformat, width, border, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// Binding for glTextureImage2DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void TextureImage2DEXT(UInt32 texture, TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTextureImage2DEXT != null, "pglTextureImage2DEXT not implemented");
			Delegates.pglTextureImage2DEXT(texture, (Int32)target, level, internalformat, width, height, border, (Int32)format, (Int32)type, pixels);
			LogFunction("glTextureImage2DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, 0x{9})", texture, target, level, internalformat, width, height, border, format, type, pixels.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureImage2DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void TextureImage2DEXT(UInt32 texture, TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TextureImage2DEXT(texture, target, level, internalformat, width, height, border, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// Binding for glTextureSubImage1DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void TextureSubImage1DEXT(UInt32 texture, TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTextureSubImage1DEXT != null, "pglTextureSubImage1DEXT not implemented");
			Delegates.pglTextureSubImage1DEXT(texture, (Int32)target, level, xoffset, width, (Int32)format, (Int32)type, pixels);
			LogFunction("glTextureSubImage1DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, 0x{7})", texture, target, level, xoffset, width, format, type, pixels.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureSubImage1DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void TextureSubImage1DEXT(UInt32 texture, TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TextureSubImage1DEXT(texture, target, level, xoffset, width, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// Binding for glTextureSubImage2DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void TextureSubImage2DEXT(UInt32 texture, TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTextureSubImage2DEXT != null, "pglTextureSubImage2DEXT not implemented");
			Delegates.pglTextureSubImage2DEXT(texture, (Int32)target, level, xoffset, yoffset, width, height, (Int32)format, (Int32)type, pixels);
			LogFunction("glTextureSubImage2DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, 0x{9})", texture, target, level, xoffset, yoffset, width, height, format, type, pixels.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureSubImage2DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void TextureSubImage2DEXT(UInt32 texture, TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TextureSubImage2DEXT(texture, target, level, xoffset, yoffset, width, height, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// Binding for glCopyTextureImage1DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CopyTextureImage1DEXT(UInt32 texture, TextureTarget target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 border)
		{
			Debug.Assert(Delegates.pglCopyTextureImage1DEXT != null, "pglCopyTextureImage1DEXT not implemented");
			Delegates.pglCopyTextureImage1DEXT(texture, (Int32)target, level, internalformat, x, y, width, border);
			LogFunction("glCopyTextureImage1DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", texture, target, level, LogEnumName(internalformat), x, y, width, border);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCopyTextureImage2DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CopyTextureImage2DEXT(UInt32 texture, TextureTarget target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border)
		{
			Debug.Assert(Delegates.pglCopyTextureImage2DEXT != null, "pglCopyTextureImage2DEXT not implemented");
			Delegates.pglCopyTextureImage2DEXT(texture, (Int32)target, level, internalformat, x, y, width, height, border);
			LogFunction("glCopyTextureImage2DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", texture, target, level, LogEnumName(internalformat), x, y, width, height, border);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCopyTextureSubImage1DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CopyTextureSubImage1DEXT(UInt32 texture, TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width)
		{
			Debug.Assert(Delegates.pglCopyTextureSubImage1DEXT != null, "pglCopyTextureSubImage1DEXT not implemented");
			Delegates.pglCopyTextureSubImage1DEXT(texture, (Int32)target, level, xoffset, x, y, width);
			LogFunction("glCopyTextureSubImage1DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", texture, target, level, xoffset, x, y, width);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCopyTextureSubImage2DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CopyTextureSubImage2DEXT(UInt32 texture, TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglCopyTextureSubImage2DEXT != null, "pglCopyTextureSubImage2DEXT not implemented");
			Delegates.pglCopyTextureSubImage2DEXT(texture, (Int32)target, level, xoffset, yoffset, x, y, width, height);
			LogFunction("glCopyTextureSubImage2DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", texture, target, level, xoffset, yoffset, x, y, width, height);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetTextureImageEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetTextureImageEXT(UInt32 texture, TextureTarget target, Int32 level, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglGetTextureImageEXT != null, "pglGetTextureImageEXT not implemented");
			Delegates.pglGetTextureImageEXT(texture, (Int32)target, level, (Int32)format, (Int32)type, pixels);
			LogFunction("glGetTextureImageEXT({0}, {1}, {2}, {3}, {4}, 0x{5})", texture, target, level, format, type, pixels.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetTextureImageEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetTextureImageEXT(UInt32 texture, TextureTarget target, Int32 level, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				GetTextureImageEXT(texture, target, level, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// Binding for glGetTextureParameterfvEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetTextureParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetTextureParameterEXT(UInt32 texture, TextureTarget target, GetTextureParameter pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTextureParameterfvEXT != null, "pglGetTextureParameterfvEXT not implemented");
					Delegates.pglGetTextureParameterfvEXT(texture, (Int32)target, (Int32)pname, p_params);
					LogFunction("glGetTextureParameterfvEXT({0}, {1}, {2}, {3})", texture, target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetTextureParameterivEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetTextureParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetTextureParameterEXT(UInt32 texture, TextureTarget target, GetTextureParameter pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTextureParameterivEXT != null, "pglGetTextureParameterivEXT not implemented");
					Delegates.pglGetTextureParameterivEXT(texture, (Int32)target, (Int32)pname, p_params);
					LogFunction("glGetTextureParameterivEXT({0}, {1}, {2}, {3})", texture, target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetTextureLevelParameterfvEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetTextureParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetTextureLevelParameterEXT(UInt32 texture, TextureTarget target, Int32 level, GetTextureParameter pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTextureLevelParameterfvEXT != null, "pglGetTextureLevelParameterfvEXT not implemented");
					Delegates.pglGetTextureLevelParameterfvEXT(texture, (Int32)target, level, (Int32)pname, p_params);
					LogFunction("glGetTextureLevelParameterfvEXT({0}, {1}, {2}, {3}, {4})", texture, target, level, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetTextureLevelParameterivEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetTextureParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetTextureLevelParameterEXT(UInt32 texture, TextureTarget target, Int32 level, GetTextureParameter pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTextureLevelParameterivEXT != null, "pglGetTextureLevelParameterivEXT not implemented");
					Delegates.pglGetTextureLevelParameterivEXT(texture, (Int32)target, level, (Int32)pname, p_params);
					LogFunction("glGetTextureLevelParameterivEXT({0}, {1}, {2}, {3}, {4})", texture, target, level, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureImage3DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void TextureImage3DEXT(UInt32 texture, TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTextureImage3DEXT != null, "pglTextureImage3DEXT not implemented");
			Delegates.pglTextureImage3DEXT(texture, (Int32)target, level, internalformat, width, height, depth, border, (Int32)format, (Int32)type, pixels);
			LogFunction("glTextureImage3DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, 0x{10})", texture, target, level, internalformat, width, height, depth, border, format, type, pixels.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureImage3DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void TextureImage3DEXT(UInt32 texture, TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TextureImage3DEXT(texture, target, level, internalformat, width, height, depth, border, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// Binding for glTextureSubImage3DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void TextureSubImage3DEXT(UInt32 texture, TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTextureSubImage3DEXT != null, "pglTextureSubImage3DEXT not implemented");
			Delegates.pglTextureSubImage3DEXT(texture, (Int32)target, level, xoffset, yoffset, zoffset, width, height, depth, (Int32)format, (Int32)type, pixels);
			LogFunction("glTextureSubImage3DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, 0x{11})", texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureSubImage3DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void TextureSubImage3DEXT(UInt32 texture, TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TextureSubImage3DEXT(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// Binding for glCopyTextureSubImage3DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CopyTextureSubImage3DEXT(UInt32 texture, TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglCopyTextureSubImage3DEXT != null, "pglCopyTextureSubImage3DEXT not implemented");
			Delegates.pglCopyTextureSubImage3DEXT(texture, (Int32)target, level, xoffset, yoffset, zoffset, x, y, width, height);
			LogFunction("glCopyTextureSubImage3DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", texture, target, level, xoffset, yoffset, zoffset, x, y, width, height);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glBindMultiTextureEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void BindMultiTextureEXT(Int32 texunit, TextureTarget target, UInt32 texture)
		{
			Debug.Assert(Delegates.pglBindMultiTextureEXT != null, "pglBindMultiTextureEXT not implemented");
			Delegates.pglBindMultiTextureEXT(texunit, (Int32)target, texture);
			LogFunction("glBindMultiTextureEXT({0}, {1}, {2})", LogEnumName(texunit), target, texture);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexCoordPointerEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:TexCoordPointerType"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexCoordPointerEXT(Int32 texunit, Int32 size, TexCoordPointerType type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglMultiTexCoordPointerEXT != null, "pglMultiTexCoordPointerEXT not implemented");
			Delegates.pglMultiTexCoordPointerEXT(texunit, size, (Int32)type, stride, pointer);
			LogFunction("glMultiTexCoordPointerEXT({0}, {1}, {2}, {3}, 0x{4})", LogEnumName(texunit), size, type, stride, pointer.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexCoordPointerEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:TexCoordPointerType"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexCoordPointerEXT(Int32 texunit, Int32 size, TexCoordPointerType type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				MultiTexCoordPointerEXT(texunit, size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glMultiTexEnvfEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureEnvTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureEnvParameter"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexEnvEXT(Int32 texunit, TextureEnvTarget target, TextureEnvParameter pname, float param)
		{
			Debug.Assert(Delegates.pglMultiTexEnvfEXT != null, "pglMultiTexEnvfEXT not implemented");
			Delegates.pglMultiTexEnvfEXT(texunit, (Int32)target, (Int32)pname, param);
			LogFunction("glMultiTexEnvfEXT({0}, {1}, {2}, {3})", LogEnumName(texunit), target, pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexEnvfvEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureEnvTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureEnvParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexEnvEXT(Int32 texunit, TextureEnvTarget target, TextureEnvParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglMultiTexEnvfvEXT != null, "pglMultiTexEnvfvEXT not implemented");
					Delegates.pglMultiTexEnvfvEXT(texunit, (Int32)target, (Int32)pname, p_params);
					LogFunction("glMultiTexEnvfvEXT({0}, {1}, {2}, {3})", LogEnumName(texunit), target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexEnviEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureEnvTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureEnvParameter"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexEnvEXT(Int32 texunit, TextureEnvTarget target, TextureEnvParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglMultiTexEnviEXT != null, "pglMultiTexEnviEXT not implemented");
			Delegates.pglMultiTexEnviEXT(texunit, (Int32)target, (Int32)pname, param);
			LogFunction("glMultiTexEnviEXT({0}, {1}, {2}, {3})", LogEnumName(texunit), target, pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexEnvivEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureEnvTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureEnvParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexEnvEXT(Int32 texunit, TextureEnvTarget target, TextureEnvParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglMultiTexEnvivEXT != null, "pglMultiTexEnvivEXT not implemented");
					Delegates.pglMultiTexEnvivEXT(texunit, (Int32)target, (Int32)pname, p_params);
					LogFunction("glMultiTexEnvivEXT({0}, {1}, {2}, {3})", LogEnumName(texunit), target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexGendEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coord">
		/// A <see cref="T:TextureCoordName"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureGenParameter"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexGenEXT(Int32 texunit, TextureCoordName coord, TextureGenParameter pname, double param)
		{
			Debug.Assert(Delegates.pglMultiTexGendEXT != null, "pglMultiTexGendEXT not implemented");
			Delegates.pglMultiTexGendEXT(texunit, (Int32)coord, (Int32)pname, param);
			LogFunction("glMultiTexGendEXT({0}, {1}, {2}, {3})", LogEnumName(texunit), coord, pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexGendvEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coord">
		/// A <see cref="T:TextureCoordName"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureGenParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexGenEXT(Int32 texunit, TextureCoordName coord, TextureGenParameter pname, double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglMultiTexGendvEXT != null, "pglMultiTexGendvEXT not implemented");
					Delegates.pglMultiTexGendvEXT(texunit, (Int32)coord, (Int32)pname, p_params);
					LogFunction("glMultiTexGendvEXT({0}, {1}, {2}, {3})", LogEnumName(texunit), coord, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexGenfEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coord">
		/// A <see cref="T:TextureCoordName"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureGenParameter"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexGenEXT(Int32 texunit, TextureCoordName coord, TextureGenParameter pname, float param)
		{
			Debug.Assert(Delegates.pglMultiTexGenfEXT != null, "pglMultiTexGenfEXT not implemented");
			Delegates.pglMultiTexGenfEXT(texunit, (Int32)coord, (Int32)pname, param);
			LogFunction("glMultiTexGenfEXT({0}, {1}, {2}, {3})", LogEnumName(texunit), coord, pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexGenfvEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coord">
		/// A <see cref="T:TextureCoordName"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureGenParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexGenEXT(Int32 texunit, TextureCoordName coord, TextureGenParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglMultiTexGenfvEXT != null, "pglMultiTexGenfvEXT not implemented");
					Delegates.pglMultiTexGenfvEXT(texunit, (Int32)coord, (Int32)pname, p_params);
					LogFunction("glMultiTexGenfvEXT({0}, {1}, {2}, {3})", LogEnumName(texunit), coord, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexGeniEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coord">
		/// A <see cref="T:TextureCoordName"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureGenParameter"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexGenEXT(Int32 texunit, TextureCoordName coord, TextureGenParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglMultiTexGeniEXT != null, "pglMultiTexGeniEXT not implemented");
			Delegates.pglMultiTexGeniEXT(texunit, (Int32)coord, (Int32)pname, param);
			LogFunction("glMultiTexGeniEXT({0}, {1}, {2}, {3})", LogEnumName(texunit), coord, pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexGenivEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coord">
		/// A <see cref="T:TextureCoordName"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureGenParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexGenEXT(Int32 texunit, TextureCoordName coord, TextureGenParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglMultiTexGenivEXT != null, "pglMultiTexGenivEXT not implemented");
					Delegates.pglMultiTexGenivEXT(texunit, (Int32)coord, (Int32)pname, p_params);
					LogFunction("glMultiTexGenivEXT({0}, {1}, {2}, {3})", LogEnumName(texunit), coord, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetMultiTexEnvfvEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureEnvTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureEnvParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetMultiTexEnvEXT(Int32 texunit, TextureEnvTarget target, TextureEnvParameter pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMultiTexEnvfvEXT != null, "pglGetMultiTexEnvfvEXT not implemented");
					Delegates.pglGetMultiTexEnvfvEXT(texunit, (Int32)target, (Int32)pname, p_params);
					LogFunction("glGetMultiTexEnvfvEXT({0}, {1}, {2}, {3})", LogEnumName(texunit), target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetMultiTexEnvivEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureEnvTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureEnvParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetMultiTexEnvEXT(Int32 texunit, TextureEnvTarget target, TextureEnvParameter pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMultiTexEnvivEXT != null, "pglGetMultiTexEnvivEXT not implemented");
					Delegates.pglGetMultiTexEnvivEXT(texunit, (Int32)target, (Int32)pname, p_params);
					LogFunction("glGetMultiTexEnvivEXT({0}, {1}, {2}, {3})", LogEnumName(texunit), target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetMultiTexGendvEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coord">
		/// A <see cref="T:TextureCoordName"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureGenParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetMultiTexGenEXT(Int32 texunit, TextureCoordName coord, TextureGenParameter pname, [Out] double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMultiTexGendvEXT != null, "pglGetMultiTexGendvEXT not implemented");
					Delegates.pglGetMultiTexGendvEXT(texunit, (Int32)coord, (Int32)pname, p_params);
					LogFunction("glGetMultiTexGendvEXT({0}, {1}, {2}, {3})", LogEnumName(texunit), coord, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetMultiTexGenfvEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coord">
		/// A <see cref="T:TextureCoordName"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureGenParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetMultiTexGenEXT(Int32 texunit, TextureCoordName coord, TextureGenParameter pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMultiTexGenfvEXT != null, "pglGetMultiTexGenfvEXT not implemented");
					Delegates.pglGetMultiTexGenfvEXT(texunit, (Int32)coord, (Int32)pname, p_params);
					LogFunction("glGetMultiTexGenfvEXT({0}, {1}, {2}, {3})", LogEnumName(texunit), coord, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetMultiTexGenivEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coord">
		/// A <see cref="T:TextureCoordName"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureGenParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetMultiTexGenEXT(Int32 texunit, TextureCoordName coord, TextureGenParameter pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMultiTexGenivEXT != null, "pglGetMultiTexGenivEXT not implemented");
					Delegates.pglGetMultiTexGenivEXT(texunit, (Int32)coord, (Int32)pname, p_params);
					LogFunction("glGetMultiTexGenivEXT({0}, {1}, {2}, {3})", LogEnumName(texunit), coord, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexParameteriEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureParameterName"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexParameterEXT(Int32 texunit, TextureTarget target, TextureParameterName pname, Int32 param)
		{
			Debug.Assert(Delegates.pglMultiTexParameteriEXT != null, "pglMultiTexParameteriEXT not implemented");
			Delegates.pglMultiTexParameteriEXT(texunit, (Int32)target, (Int32)pname, param);
			LogFunction("glMultiTexParameteriEXT({0}, {1}, {2}, {3})", LogEnumName(texunit), target, pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexParameterivEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexParameterEXT(Int32 texunit, TextureTarget target, TextureParameterName pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglMultiTexParameterivEXT != null, "pglMultiTexParameterivEXT not implemented");
					Delegates.pglMultiTexParameterivEXT(texunit, (Int32)target, (Int32)pname, p_params);
					LogFunction("glMultiTexParameterivEXT({0}, {1}, {2}, {3})", LogEnumName(texunit), target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexParameterfEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureParameterName"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexParameterEXT(Int32 texunit, TextureTarget target, TextureParameterName pname, float param)
		{
			Debug.Assert(Delegates.pglMultiTexParameterfEXT != null, "pglMultiTexParameterfEXT not implemented");
			Delegates.pglMultiTexParameterfEXT(texunit, (Int32)target, (Int32)pname, param);
			LogFunction("glMultiTexParameterfEXT({0}, {1}, {2}, {3})", LogEnumName(texunit), target, pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexParameterfvEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexParameterEXT(Int32 texunit, TextureTarget target, TextureParameterName pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglMultiTexParameterfvEXT != null, "pglMultiTexParameterfvEXT not implemented");
					Delegates.pglMultiTexParameterfvEXT(texunit, (Int32)target, (Int32)pname, p_params);
					LogFunction("glMultiTexParameterfvEXT({0}, {1}, {2}, {3})", LogEnumName(texunit), target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexImage1DEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexImage1DEXT(Int32 texunit, TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglMultiTexImage1DEXT != null, "pglMultiTexImage1DEXT not implemented");
			Delegates.pglMultiTexImage1DEXT(texunit, (Int32)target, level, internalformat, width, border, (Int32)format, (Int32)type, pixels);
			LogFunction("glMultiTexImage1DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, 0x{8})", LogEnumName(texunit), target, level, internalformat, width, border, format, type, pixels.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexImage1DEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexImage1DEXT(Int32 texunit, TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 border, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				MultiTexImage1DEXT(texunit, target, level, internalformat, width, border, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// Binding for glMultiTexImage2DEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexImage2DEXT(Int32 texunit, TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglMultiTexImage2DEXT != null, "pglMultiTexImage2DEXT not implemented");
			Delegates.pglMultiTexImage2DEXT(texunit, (Int32)target, level, internalformat, width, height, border, (Int32)format, (Int32)type, pixels);
			LogFunction("glMultiTexImage2DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, 0x{9})", LogEnumName(texunit), target, level, internalformat, width, height, border, format, type, pixels.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexImage2DEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexImage2DEXT(Int32 texunit, TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				MultiTexImage2DEXT(texunit, target, level, internalformat, width, height, border, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// Binding for glMultiTexSubImage1DEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexSubImage1DEXT(Int32 texunit, TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglMultiTexSubImage1DEXT != null, "pglMultiTexSubImage1DEXT not implemented");
			Delegates.pglMultiTexSubImage1DEXT(texunit, (Int32)target, level, xoffset, width, (Int32)format, (Int32)type, pixels);
			LogFunction("glMultiTexSubImage1DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, 0x{7})", LogEnumName(texunit), target, level, xoffset, width, format, type, pixels.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexSubImage1DEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexSubImage1DEXT(Int32 texunit, TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				MultiTexSubImage1DEXT(texunit, target, level, xoffset, width, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// Binding for glMultiTexSubImage2DEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexSubImage2DEXT(Int32 texunit, TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglMultiTexSubImage2DEXT != null, "pglMultiTexSubImage2DEXT not implemented");
			Delegates.pglMultiTexSubImage2DEXT(texunit, (Int32)target, level, xoffset, yoffset, width, height, (Int32)format, (Int32)type, pixels);
			LogFunction("glMultiTexSubImage2DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, 0x{9})", LogEnumName(texunit), target, level, xoffset, yoffset, width, height, format, type, pixels.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexSubImage2DEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexSubImage2DEXT(Int32 texunit, TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				MultiTexSubImage2DEXT(texunit, target, level, xoffset, yoffset, width, height, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// Binding for glCopyMultiTexImage1DEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CopyMultiTexImage1DEXT(Int32 texunit, TextureTarget target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 border)
		{
			Debug.Assert(Delegates.pglCopyMultiTexImage1DEXT != null, "pglCopyMultiTexImage1DEXT not implemented");
			Delegates.pglCopyMultiTexImage1DEXT(texunit, (Int32)target, level, internalformat, x, y, width, border);
			LogFunction("glCopyMultiTexImage1DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", LogEnumName(texunit), target, level, LogEnumName(internalformat), x, y, width, border);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCopyMultiTexImage2DEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CopyMultiTexImage2DEXT(Int32 texunit, TextureTarget target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border)
		{
			Debug.Assert(Delegates.pglCopyMultiTexImage2DEXT != null, "pglCopyMultiTexImage2DEXT not implemented");
			Delegates.pglCopyMultiTexImage2DEXT(texunit, (Int32)target, level, internalformat, x, y, width, height, border);
			LogFunction("glCopyMultiTexImage2DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", LogEnumName(texunit), target, level, LogEnumName(internalformat), x, y, width, height, border);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCopyMultiTexSubImage1DEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CopyMultiTexSubImage1DEXT(Int32 texunit, TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width)
		{
			Debug.Assert(Delegates.pglCopyMultiTexSubImage1DEXT != null, "pglCopyMultiTexSubImage1DEXT not implemented");
			Delegates.pglCopyMultiTexSubImage1DEXT(texunit, (Int32)target, level, xoffset, x, y, width);
			LogFunction("glCopyMultiTexSubImage1DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", LogEnumName(texunit), target, level, xoffset, x, y, width);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCopyMultiTexSubImage2DEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CopyMultiTexSubImage2DEXT(Int32 texunit, TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglCopyMultiTexSubImage2DEXT != null, "pglCopyMultiTexSubImage2DEXT not implemented");
			Delegates.pglCopyMultiTexSubImage2DEXT(texunit, (Int32)target, level, xoffset, yoffset, x, y, width, height);
			LogFunction("glCopyMultiTexSubImage2DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", LogEnumName(texunit), target, level, xoffset, yoffset, x, y, width, height);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetMultiTexImageEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetMultiTexImageEXT(Int32 texunit, TextureTarget target, Int32 level, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglGetMultiTexImageEXT != null, "pglGetMultiTexImageEXT not implemented");
			Delegates.pglGetMultiTexImageEXT(texunit, (Int32)target, level, (Int32)format, (Int32)type, pixels);
			LogFunction("glGetMultiTexImageEXT({0}, {1}, {2}, {3}, {4}, 0x{5})", LogEnumName(texunit), target, level, format, type, pixels.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetMultiTexImageEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetMultiTexImageEXT(Int32 texunit, TextureTarget target, Int32 level, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				GetMultiTexImageEXT(texunit, target, level, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// Binding for glGetMultiTexParameterfvEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetTextureParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetMultiTexParameterEXT(Int32 texunit, TextureTarget target, GetTextureParameter pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMultiTexParameterfvEXT != null, "pglGetMultiTexParameterfvEXT not implemented");
					Delegates.pglGetMultiTexParameterfvEXT(texunit, (Int32)target, (Int32)pname, p_params);
					LogFunction("glGetMultiTexParameterfvEXT({0}, {1}, {2}, {3})", LogEnumName(texunit), target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetMultiTexParameterivEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetTextureParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetMultiTexParameterEXT(Int32 texunit, TextureTarget target, GetTextureParameter pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMultiTexParameterivEXT != null, "pglGetMultiTexParameterivEXT not implemented");
					Delegates.pglGetMultiTexParameterivEXT(texunit, (Int32)target, (Int32)pname, p_params);
					LogFunction("glGetMultiTexParameterivEXT({0}, {1}, {2}, {3})", LogEnumName(texunit), target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetMultiTexLevelParameterfvEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetTextureParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetMultiTexLevelParameterEXT(Int32 texunit, TextureTarget target, Int32 level, GetTextureParameter pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMultiTexLevelParameterfvEXT != null, "pglGetMultiTexLevelParameterfvEXT not implemented");
					Delegates.pglGetMultiTexLevelParameterfvEXT(texunit, (Int32)target, level, (Int32)pname, p_params);
					LogFunction("glGetMultiTexLevelParameterfvEXT({0}, {1}, {2}, {3}, {4})", LogEnumName(texunit), target, level, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetMultiTexLevelParameterivEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetTextureParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetMultiTexLevelParameterEXT(Int32 texunit, TextureTarget target, Int32 level, GetTextureParameter pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMultiTexLevelParameterivEXT != null, "pglGetMultiTexLevelParameterivEXT not implemented");
					Delegates.pglGetMultiTexLevelParameterivEXT(texunit, (Int32)target, level, (Int32)pname, p_params);
					LogFunction("glGetMultiTexLevelParameterivEXT({0}, {1}, {2}, {3}, {4})", LogEnumName(texunit), target, level, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexImage3DEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexImage3DEXT(Int32 texunit, TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglMultiTexImage3DEXT != null, "pglMultiTexImage3DEXT not implemented");
			Delegates.pglMultiTexImage3DEXT(texunit, (Int32)target, level, internalformat, width, height, depth, border, (Int32)format, (Int32)type, pixels);
			LogFunction("glMultiTexImage3DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, 0x{10})", LogEnumName(texunit), target, level, internalformat, width, height, depth, border, format, type, pixels.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexImage3DEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexImage3DEXT(Int32 texunit, TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				MultiTexImage3DEXT(texunit, target, level, internalformat, width, height, depth, border, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// Binding for glMultiTexSubImage3DEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexSubImage3DEXT(Int32 texunit, TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglMultiTexSubImage3DEXT != null, "pglMultiTexSubImage3DEXT not implemented");
			Delegates.pglMultiTexSubImage3DEXT(texunit, (Int32)target, level, xoffset, yoffset, zoffset, width, height, depth, (Int32)format, (Int32)type, pixels);
			LogFunction("glMultiTexSubImage3DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, 0x{11})", LogEnumName(texunit), target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexSubImage3DEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexSubImage3DEXT(Int32 texunit, TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				MultiTexSubImage3DEXT(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// Binding for glCopyMultiTexSubImage3DEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CopyMultiTexSubImage3DEXT(Int32 texunit, TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglCopyMultiTexSubImage3DEXT != null, "pglCopyMultiTexSubImage3DEXT not implemented");
			Delegates.pglCopyMultiTexSubImage3DEXT(texunit, (Int32)target, level, xoffset, yoffset, zoffset, x, y, width, height);
			LogFunction("glCopyMultiTexSubImage3DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", LogEnumName(texunit), target, level, xoffset, yoffset, zoffset, x, y, width, height);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glEnableClientStateIndexedEXT.
		/// </summary>
		/// <param name="array">
		/// A <see cref="T:EnableCap"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void EnableClientStateIndexedEXT(EnableCap array, UInt32 index)
		{
			Debug.Assert(Delegates.pglEnableClientStateIndexedEXT != null, "pglEnableClientStateIndexedEXT not implemented");
			Delegates.pglEnableClientStateIndexedEXT((Int32)array, index);
			LogFunction("glEnableClientStateIndexedEXT({0}, {1})", array, index);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDisableClientStateIndexedEXT.
		/// </summary>
		/// <param name="array">
		/// A <see cref="T:EnableCap"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void DisableClientStateIndexedEXT(EnableCap array, UInt32 index)
		{
			Debug.Assert(Delegates.pglDisableClientStateIndexedEXT != null, "pglDisableClientStateIndexedEXT not implemented");
			Delegates.pglDisableClientStateIndexedEXT((Int32)array, index);
			LogFunction("glDisableClientStateIndexedEXT({0}, {1})", array, index);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPointerIndexedvEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetPointerIndexedEXT(Int32 target, UInt32 index, out IntPtr data)
		{
			unsafe {
				fixed (IntPtr* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetPointerIndexedvEXT != null, "pglGetPointerIndexedvEXT not implemented");
					Delegates.pglGetPointerIndexedvEXT(target, index, p_data);
					LogFunction("glGetPointerIndexedvEXT({0}, {1}, 0x{2})", LogEnumName(target), index, data.ToString("X8"));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPointerIndexedvEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetPointerIndexedEXT(Int32 target, UInt32 index, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				GetPointerIndexedEXT(target, index, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// Binding for glCompressedTextureImage3DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bits">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CompressedTextureImage3DEXT(UInt32 texture, TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr bits)
		{
			Debug.Assert(Delegates.pglCompressedTextureImage3DEXT != null, "pglCompressedTextureImage3DEXT not implemented");
			Delegates.pglCompressedTextureImage3DEXT(texture, (Int32)target, level, internalformat, width, height, depth, border, imageSize, bits);
			LogFunction("glCompressedTextureImage3DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, 0x{9})", texture, target, level, LogEnumName(internalformat), width, height, depth, border, imageSize, bits.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCompressedTextureImage3DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bits">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CompressedTextureImage3DEXT(UInt32 texture, TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, Object bits)
		{
			GCHandle pin_bits = GCHandle.Alloc(bits, GCHandleType.Pinned);
			try {
				CompressedTextureImage3DEXT(texture, target, level, internalformat, width, height, depth, border, imageSize, pin_bits.AddrOfPinnedObject());
			} finally {
				pin_bits.Free();
			}
		}

		/// <summary>
		/// Binding for glCompressedTextureImage2DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bits">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CompressedTextureImage2DEXT(UInt32 texture, TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr bits)
		{
			Debug.Assert(Delegates.pglCompressedTextureImage2DEXT != null, "pglCompressedTextureImage2DEXT not implemented");
			Delegates.pglCompressedTextureImage2DEXT(texture, (Int32)target, level, internalformat, width, height, border, imageSize, bits);
			LogFunction("glCompressedTextureImage2DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, 0x{8})", texture, target, level, LogEnumName(internalformat), width, height, border, imageSize, bits.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCompressedTextureImage2DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bits">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CompressedTextureImage2DEXT(UInt32 texture, TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, Object bits)
		{
			GCHandle pin_bits = GCHandle.Alloc(bits, GCHandleType.Pinned);
			try {
				CompressedTextureImage2DEXT(texture, target, level, internalformat, width, height, border, imageSize, pin_bits.AddrOfPinnedObject());
			} finally {
				pin_bits.Free();
			}
		}

		/// <summary>
		/// Binding for glCompressedTextureImage1DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bits">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CompressedTextureImage1DEXT(UInt32 texture, TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr bits)
		{
			Debug.Assert(Delegates.pglCompressedTextureImage1DEXT != null, "pglCompressedTextureImage1DEXT not implemented");
			Delegates.pglCompressedTextureImage1DEXT(texture, (Int32)target, level, internalformat, width, border, imageSize, bits);
			LogFunction("glCompressedTextureImage1DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, 0x{7})", texture, target, level, LogEnumName(internalformat), width, border, imageSize, bits.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCompressedTextureImage1DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bits">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CompressedTextureImage1DEXT(UInt32 texture, TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 imageSize, Object bits)
		{
			GCHandle pin_bits = GCHandle.Alloc(bits, GCHandleType.Pinned);
			try {
				CompressedTextureImage1DEXT(texture, target, level, internalformat, width, border, imageSize, pin_bits.AddrOfPinnedObject());
			} finally {
				pin_bits.Free();
			}
		}

		/// <summary>
		/// Binding for glCompressedTextureSubImage3DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bits">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CompressedTextureSubImage3DEXT(UInt32 texture, TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, Int32 imageSize, IntPtr bits)
		{
			Debug.Assert(Delegates.pglCompressedTextureSubImage3DEXT != null, "pglCompressedTextureSubImage3DEXT not implemented");
			Delegates.pglCompressedTextureSubImage3DEXT(texture, (Int32)target, level, xoffset, yoffset, zoffset, width, height, depth, (Int32)format, imageSize, bits);
			LogFunction("glCompressedTextureSubImage3DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, 0x{11})", texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, bits.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCompressedTextureSubImage3DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bits">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CompressedTextureSubImage3DEXT(UInt32 texture, TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, Int32 imageSize, Object bits)
		{
			GCHandle pin_bits = GCHandle.Alloc(bits, GCHandleType.Pinned);
			try {
				CompressedTextureSubImage3DEXT(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, pin_bits.AddrOfPinnedObject());
			} finally {
				pin_bits.Free();
			}
		}

		/// <summary>
		/// Binding for glCompressedTextureSubImage2DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bits">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CompressedTextureSubImage2DEXT(UInt32 texture, TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, Int32 imageSize, IntPtr bits)
		{
			Debug.Assert(Delegates.pglCompressedTextureSubImage2DEXT != null, "pglCompressedTextureSubImage2DEXT not implemented");
			Delegates.pglCompressedTextureSubImage2DEXT(texture, (Int32)target, level, xoffset, yoffset, width, height, (Int32)format, imageSize, bits);
			LogFunction("glCompressedTextureSubImage2DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, 0x{9})", texture, target, level, xoffset, yoffset, width, height, format, imageSize, bits.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCompressedTextureSubImage2DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bits">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CompressedTextureSubImage2DEXT(UInt32 texture, TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, Int32 imageSize, Object bits)
		{
			GCHandle pin_bits = GCHandle.Alloc(bits, GCHandleType.Pinned);
			try {
				CompressedTextureSubImage2DEXT(texture, target, level, xoffset, yoffset, width, height, format, imageSize, pin_bits.AddrOfPinnedObject());
			} finally {
				pin_bits.Free();
			}
		}

		/// <summary>
		/// Binding for glCompressedTextureSubImage1DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bits">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CompressedTextureSubImage1DEXT(UInt32 texture, TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, Int32 imageSize, IntPtr bits)
		{
			Debug.Assert(Delegates.pglCompressedTextureSubImage1DEXT != null, "pglCompressedTextureSubImage1DEXT not implemented");
			Delegates.pglCompressedTextureSubImage1DEXT(texture, (Int32)target, level, xoffset, width, (Int32)format, imageSize, bits);
			LogFunction("glCompressedTextureSubImage1DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, 0x{7})", texture, target, level, xoffset, width, format, imageSize, bits.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCompressedTextureSubImage1DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bits">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CompressedTextureSubImage1DEXT(UInt32 texture, TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, Int32 imageSize, Object bits)
		{
			GCHandle pin_bits = GCHandle.Alloc(bits, GCHandleType.Pinned);
			try {
				CompressedTextureSubImage1DEXT(texture, target, level, xoffset, width, format, imageSize, pin_bits.AddrOfPinnedObject());
			} finally {
				pin_bits.Free();
			}
		}

		/// <summary>
		/// Binding for glGetCompressedTextureImageEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="lod">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="img">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetCompressedTextureImageEXT(UInt32 texture, TextureTarget target, Int32 lod, IntPtr img)
		{
			Debug.Assert(Delegates.pglGetCompressedTextureImageEXT != null, "pglGetCompressedTextureImageEXT not implemented");
			Delegates.pglGetCompressedTextureImageEXT(texture, (Int32)target, lod, img);
			LogFunction("glGetCompressedTextureImageEXT({0}, {1}, {2}, 0x{3})", texture, target, lod, img.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetCompressedTextureImageEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="lod">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="img">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetCompressedTextureImageEXT(UInt32 texture, TextureTarget target, Int32 lod, Object img)
		{
			GCHandle pin_img = GCHandle.Alloc(img, GCHandleType.Pinned);
			try {
				GetCompressedTextureImageEXT(texture, target, lod, pin_img.AddrOfPinnedObject());
			} finally {
				pin_img.Free();
			}
		}

		/// <summary>
		/// Binding for glCompressedMultiTexImage3DEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bits">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CompressedMultiTexImage3DEXT(Int32 texunit, TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr bits)
		{
			Debug.Assert(Delegates.pglCompressedMultiTexImage3DEXT != null, "pglCompressedMultiTexImage3DEXT not implemented");
			Delegates.pglCompressedMultiTexImage3DEXT(texunit, (Int32)target, level, internalformat, width, height, depth, border, imageSize, bits);
			LogFunction("glCompressedMultiTexImage3DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, 0x{9})", LogEnumName(texunit), target, level, LogEnumName(internalformat), width, height, depth, border, imageSize, bits.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCompressedMultiTexImage3DEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bits">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CompressedMultiTexImage3DEXT(Int32 texunit, TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, Object bits)
		{
			GCHandle pin_bits = GCHandle.Alloc(bits, GCHandleType.Pinned);
			try {
				CompressedMultiTexImage3DEXT(texunit, target, level, internalformat, width, height, depth, border, imageSize, pin_bits.AddrOfPinnedObject());
			} finally {
				pin_bits.Free();
			}
		}

		/// <summary>
		/// Binding for glCompressedMultiTexImage2DEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bits">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CompressedMultiTexImage2DEXT(Int32 texunit, TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr bits)
		{
			Debug.Assert(Delegates.pglCompressedMultiTexImage2DEXT != null, "pglCompressedMultiTexImage2DEXT not implemented");
			Delegates.pglCompressedMultiTexImage2DEXT(texunit, (Int32)target, level, internalformat, width, height, border, imageSize, bits);
			LogFunction("glCompressedMultiTexImage2DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, 0x{8})", LogEnumName(texunit), target, level, LogEnumName(internalformat), width, height, border, imageSize, bits.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCompressedMultiTexImage2DEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bits">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CompressedMultiTexImage2DEXT(Int32 texunit, TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, Object bits)
		{
			GCHandle pin_bits = GCHandle.Alloc(bits, GCHandleType.Pinned);
			try {
				CompressedMultiTexImage2DEXT(texunit, target, level, internalformat, width, height, border, imageSize, pin_bits.AddrOfPinnedObject());
			} finally {
				pin_bits.Free();
			}
		}

		/// <summary>
		/// Binding for glCompressedMultiTexImage1DEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bits">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CompressedMultiTexImage1DEXT(Int32 texunit, TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr bits)
		{
			Debug.Assert(Delegates.pglCompressedMultiTexImage1DEXT != null, "pglCompressedMultiTexImage1DEXT not implemented");
			Delegates.pglCompressedMultiTexImage1DEXT(texunit, (Int32)target, level, internalformat, width, border, imageSize, bits);
			LogFunction("glCompressedMultiTexImage1DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, 0x{7})", LogEnumName(texunit), target, level, LogEnumName(internalformat), width, border, imageSize, bits.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCompressedMultiTexImage1DEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bits">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CompressedMultiTexImage1DEXT(Int32 texunit, TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 imageSize, Object bits)
		{
			GCHandle pin_bits = GCHandle.Alloc(bits, GCHandleType.Pinned);
			try {
				CompressedMultiTexImage1DEXT(texunit, target, level, internalformat, width, border, imageSize, pin_bits.AddrOfPinnedObject());
			} finally {
				pin_bits.Free();
			}
		}

		/// <summary>
		/// Binding for glCompressedMultiTexSubImage3DEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bits">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CompressedMultiTexSubImage3DEXT(Int32 texunit, TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, Int32 imageSize, IntPtr bits)
		{
			Debug.Assert(Delegates.pglCompressedMultiTexSubImage3DEXT != null, "pglCompressedMultiTexSubImage3DEXT not implemented");
			Delegates.pglCompressedMultiTexSubImage3DEXT(texunit, (Int32)target, level, xoffset, yoffset, zoffset, width, height, depth, (Int32)format, imageSize, bits);
			LogFunction("glCompressedMultiTexSubImage3DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, 0x{11})", LogEnumName(texunit), target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, bits.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCompressedMultiTexSubImage3DEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bits">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CompressedMultiTexSubImage3DEXT(Int32 texunit, TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, Int32 imageSize, Object bits)
		{
			GCHandle pin_bits = GCHandle.Alloc(bits, GCHandleType.Pinned);
			try {
				CompressedMultiTexSubImage3DEXT(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, pin_bits.AddrOfPinnedObject());
			} finally {
				pin_bits.Free();
			}
		}

		/// <summary>
		/// Binding for glCompressedMultiTexSubImage2DEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bits">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CompressedMultiTexSubImage2DEXT(Int32 texunit, TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, Int32 imageSize, IntPtr bits)
		{
			Debug.Assert(Delegates.pglCompressedMultiTexSubImage2DEXT != null, "pglCompressedMultiTexSubImage2DEXT not implemented");
			Delegates.pglCompressedMultiTexSubImage2DEXT(texunit, (Int32)target, level, xoffset, yoffset, width, height, (Int32)format, imageSize, bits);
			LogFunction("glCompressedMultiTexSubImage2DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, 0x{9})", LogEnumName(texunit), target, level, xoffset, yoffset, width, height, format, imageSize, bits.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCompressedMultiTexSubImage2DEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bits">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CompressedMultiTexSubImage2DEXT(Int32 texunit, TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, Int32 imageSize, Object bits)
		{
			GCHandle pin_bits = GCHandle.Alloc(bits, GCHandleType.Pinned);
			try {
				CompressedMultiTexSubImage2DEXT(texunit, target, level, xoffset, yoffset, width, height, format, imageSize, pin_bits.AddrOfPinnedObject());
			} finally {
				pin_bits.Free();
			}
		}

		/// <summary>
		/// Binding for glCompressedMultiTexSubImage1DEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bits">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CompressedMultiTexSubImage1DEXT(Int32 texunit, TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, Int32 imageSize, IntPtr bits)
		{
			Debug.Assert(Delegates.pglCompressedMultiTexSubImage1DEXT != null, "pglCompressedMultiTexSubImage1DEXT not implemented");
			Delegates.pglCompressedMultiTexSubImage1DEXT(texunit, (Int32)target, level, xoffset, width, (Int32)format, imageSize, bits);
			LogFunction("glCompressedMultiTexSubImage1DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, 0x{7})", LogEnumName(texunit), target, level, xoffset, width, format, imageSize, bits.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCompressedMultiTexSubImage1DEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="imageSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bits">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void CompressedMultiTexSubImage1DEXT(Int32 texunit, TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, Int32 imageSize, Object bits)
		{
			GCHandle pin_bits = GCHandle.Alloc(bits, GCHandleType.Pinned);
			try {
				CompressedMultiTexSubImage1DEXT(texunit, target, level, xoffset, width, format, imageSize, pin_bits.AddrOfPinnedObject());
			} finally {
				pin_bits.Free();
			}
		}

		/// <summary>
		/// Binding for glGetCompressedMultiTexImageEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="lod">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="img">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetCompressedMultiTexImageEXT(Int32 texunit, TextureTarget target, Int32 lod, IntPtr img)
		{
			Debug.Assert(Delegates.pglGetCompressedMultiTexImageEXT != null, "pglGetCompressedMultiTexImageEXT not implemented");
			Delegates.pglGetCompressedMultiTexImageEXT(texunit, (Int32)target, lod, img);
			LogFunction("glGetCompressedMultiTexImageEXT({0}, {1}, {2}, 0x{3})", LogEnumName(texunit), target, lod, img.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetCompressedMultiTexImageEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="lod">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="img">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetCompressedMultiTexImageEXT(Int32 texunit, TextureTarget target, Int32 lod, Object img)
		{
			GCHandle pin_img = GCHandle.Alloc(img, GCHandleType.Pinned);
			try {
				GetCompressedMultiTexImageEXT(texunit, target, lod, pin_img.AddrOfPinnedObject());
			} finally {
				pin_img.Free();
			}
		}

		/// <summary>
		/// Binding for glMatrixLoadTransposefEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:MatrixMode"/>.
		/// </param>
		/// <param name="m">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MatrixLoadTransposeEXT(MatrixMode mode, float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglMatrixLoadTransposefEXT != null, "pglMatrixLoadTransposefEXT not implemented");
					Delegates.pglMatrixLoadTransposefEXT((Int32)mode, p_m);
					LogFunction("glMatrixLoadTransposefEXT({0}, {1})", mode, LogValue(m));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMatrixLoadTransposedEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:MatrixMode"/>.
		/// </param>
		/// <param name="m">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MatrixLoadTransposeEXT(MatrixMode mode, double[] m)
		{
			unsafe {
				fixed (double* p_m = m)
				{
					Debug.Assert(Delegates.pglMatrixLoadTransposedEXT != null, "pglMatrixLoadTransposedEXT not implemented");
					Delegates.pglMatrixLoadTransposedEXT((Int32)mode, p_m);
					LogFunction("glMatrixLoadTransposedEXT({0}, {1})", mode, LogValue(m));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMatrixMultTransposefEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:MatrixMode"/>.
		/// </param>
		/// <param name="m">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MatrixMultTransposeEXT(MatrixMode mode, float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglMatrixMultTransposefEXT != null, "pglMatrixMultTransposefEXT not implemented");
					Delegates.pglMatrixMultTransposefEXT((Int32)mode, p_m);
					LogFunction("glMatrixMultTransposefEXT({0}, {1})", mode, LogValue(m));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMatrixMultTransposedEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:MatrixMode"/>.
		/// </param>
		/// <param name="m">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MatrixMultTransposeEXT(MatrixMode mode, double[] m)
		{
			unsafe {
				fixed (double* p_m = m)
				{
					Debug.Assert(Delegates.pglMatrixMultTransposedEXT != null, "pglMatrixMultTransposedEXT not implemented");
					Delegates.pglMatrixMultTransposedEXT((Int32)mode, p_m);
					LogFunction("glMatrixMultTransposedEXT({0}, {1})", mode, LogValue(m));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNamedBufferDataEXT.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="usage">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedBufferDataEXT(UInt32 buffer, UInt32 size, IntPtr data, Int32 usage)
		{
			Debug.Assert(Delegates.pglNamedBufferDataEXT != null, "pglNamedBufferDataEXT not implemented");
			Delegates.pglNamedBufferDataEXT(buffer, size, data, usage);
			LogFunction("glNamedBufferDataEXT({0}, {1}, 0x{2}, {3})", buffer, size, data.ToString("X8"), LogEnumName(usage));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNamedBufferDataEXT.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="usage">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedBufferDataEXT(UInt32 buffer, UInt32 size, Object data, Int32 usage)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				NamedBufferDataEXT(buffer, size, pin_data.AddrOfPinnedObject(), usage);
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// Binding for glMapNamedBufferEXT.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="access">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static IntPtr MapNamedBufferEXT(UInt32 buffer, Int32 access)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglMapNamedBufferEXT != null, "pglMapNamedBufferEXT not implemented");
			retValue = Delegates.pglMapNamedBufferEXT(buffer, access);
			LogFunction("glMapNamedBufferEXT({0}, {1}) = {2}", buffer, LogEnumName(access), retValue.ToString("X8"));
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glUnmapNamedBufferEXT.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static bool UnmapNamedBufferEXT(UInt32 buffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pglUnmapNamedBufferEXT != null, "pglUnmapNamedBufferEXT not implemented");
			retValue = Delegates.pglUnmapNamedBufferEXT(buffer);
			LogFunction("glUnmapNamedBufferEXT({0}) = {1}", buffer, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glGetNamedBufferParameterivEXT.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetNamedBufferParameterEXT(UInt32 buffer, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetNamedBufferParameterivEXT != null, "pglGetNamedBufferParameterivEXT not implemented");
					Delegates.pglGetNamedBufferParameterivEXT(buffer, pname, p_params);
					LogFunction("glGetNamedBufferParameterivEXT({0}, {1}, {2})", buffer, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetNamedBufferPointervEXT.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetNamedBufferPointerEXT(UInt32 buffer, Int32 pname, out IntPtr @params)
		{
			unsafe {
				fixed (IntPtr* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetNamedBufferPointervEXT != null, "pglGetNamedBufferPointervEXT not implemented");
					Delegates.pglGetNamedBufferPointervEXT(buffer, pname, p_params);
					LogFunction("glGetNamedBufferPointervEXT({0}, {1}, 0x{2})", buffer, LogEnumName(pname), @params.ToString("X8"));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetNamedBufferPointervEXT.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetNamedBufferPointerEXT(UInt32 buffer, Int32 pname, Object @params)
		{
			GCHandle pin_params = GCHandle.Alloc(@params, GCHandleType.Pinned);
			try {
				GetNamedBufferPointerEXT(buffer, pname, pin_params.AddrOfPinnedObject());
			} finally {
				pin_params.Free();
			}
		}

		/// <summary>
		/// Binding for glGetNamedBufferSubDataEXT.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetNamedBufferSubDataEXT(UInt32 buffer, IntPtr offset, UInt32 size, IntPtr data)
		{
			Debug.Assert(Delegates.pglGetNamedBufferSubDataEXT != null, "pglGetNamedBufferSubDataEXT not implemented");
			Delegates.pglGetNamedBufferSubDataEXT(buffer, offset, size, data);
			LogFunction("glGetNamedBufferSubDataEXT({0}, 0x{1}, {2}, 0x{3})", buffer, offset.ToString("X8"), size, data.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetNamedBufferSubDataEXT.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetNamedBufferSubDataEXT(UInt32 buffer, IntPtr offset, UInt32 size, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				GetNamedBufferSubDataEXT(buffer, offset, size, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// Binding for glTextureBufferEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void TextureBufferEXT(UInt32 texture, TextureTarget target, Int32 internalformat, UInt32 buffer)
		{
			Debug.Assert(Delegates.pglTextureBufferEXT != null, "pglTextureBufferEXT not implemented");
			Delegates.pglTextureBufferEXT(texture, (Int32)target, internalformat, buffer);
			LogFunction("glTextureBufferEXT({0}, {1}, {2}, {3})", texture, target, LogEnumName(internalformat), buffer);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexBufferEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexBufferEXT(Int32 texunit, TextureTarget target, Int32 internalformat, UInt32 buffer)
		{
			Debug.Assert(Delegates.pglMultiTexBufferEXT != null, "pglMultiTexBufferEXT not implemented");
			Delegates.pglMultiTexBufferEXT(texunit, (Int32)target, internalformat, buffer);
			LogFunction("glMultiTexBufferEXT({0}, {1}, {2}, {3})", LogEnumName(texunit), target, LogEnumName(internalformat), buffer);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureParameterIivEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void TextureParameterIEXT(UInt32 texture, TextureTarget target, TextureParameterName pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTextureParameterIivEXT != null, "pglTextureParameterIivEXT not implemented");
					Delegates.pglTextureParameterIivEXT(texture, (Int32)target, (Int32)pname, p_params);
					LogFunction("glTextureParameterIivEXT({0}, {1}, {2}, {3})", texture, target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureParameterIuivEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void TextureParameterIEXT(UInt32 texture, TextureTarget target, TextureParameterName pname, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTextureParameterIuivEXT != null, "pglTextureParameterIuivEXT not implemented");
					Delegates.pglTextureParameterIuivEXT(texture, (Int32)target, (Int32)pname, p_params);
					LogFunction("glTextureParameterIuivEXT({0}, {1}, {2}, {3})", texture, target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetTextureParameterIivEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetTextureParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetTextureParameterIEXT(UInt32 texture, TextureTarget target, GetTextureParameter pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTextureParameterIivEXT != null, "pglGetTextureParameterIivEXT not implemented");
					Delegates.pglGetTextureParameterIivEXT(texture, (Int32)target, (Int32)pname, p_params);
					LogFunction("glGetTextureParameterIivEXT({0}, {1}, {2}, {3})", texture, target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetTextureParameterIuivEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetTextureParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetTextureParameterIEXT(UInt32 texture, TextureTarget target, GetTextureParameter pname, [Out] UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTextureParameterIuivEXT != null, "pglGetTextureParameterIuivEXT not implemented");
					Delegates.pglGetTextureParameterIuivEXT(texture, (Int32)target, (Int32)pname, p_params);
					LogFunction("glGetTextureParameterIuivEXT({0}, {1}, {2}, {3})", texture, target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexParameterIivEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexParameterIEXT(Int32 texunit, TextureTarget target, TextureParameterName pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglMultiTexParameterIivEXT != null, "pglMultiTexParameterIivEXT not implemented");
					Delegates.pglMultiTexParameterIivEXT(texunit, (Int32)target, (Int32)pname, p_params);
					LogFunction("glMultiTexParameterIivEXT({0}, {1}, {2}, {3})", LogEnumName(texunit), target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexParameterIuivEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexParameterIEXT(Int32 texunit, TextureTarget target, TextureParameterName pname, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglMultiTexParameterIuivEXT != null, "pglMultiTexParameterIuivEXT not implemented");
					Delegates.pglMultiTexParameterIuivEXT(texunit, (Int32)target, (Int32)pname, p_params);
					LogFunction("glMultiTexParameterIuivEXT({0}, {1}, {2}, {3})", LogEnumName(texunit), target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetMultiTexParameterIivEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetTextureParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetMultiTexParameterIEXT(Int32 texunit, TextureTarget target, GetTextureParameter pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMultiTexParameterIivEXT != null, "pglGetMultiTexParameterIivEXT not implemented");
					Delegates.pglGetMultiTexParameterIivEXT(texunit, (Int32)target, (Int32)pname, p_params);
					LogFunction("glGetMultiTexParameterIivEXT({0}, {1}, {2}, {3})", LogEnumName(texunit), target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetMultiTexParameterIuivEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetTextureParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetMultiTexParameterIEXT(Int32 texunit, TextureTarget target, GetTextureParameter pname, [Out] UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMultiTexParameterIuivEXT != null, "pglGetMultiTexParameterIuivEXT not implemented");
					Delegates.pglGetMultiTexParameterIuivEXT(texunit, (Int32)target, (Int32)pname, p_params);
					LogFunction("glGetMultiTexParameterIuivEXT({0}, {1}, {2}, {3})", LogEnumName(texunit), target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNamedProgramLocalParameters4fvEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedProgramLocalParameters4EXT(UInt32 program, Int32 target, UInt32 index, Int32 count, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglNamedProgramLocalParameters4fvEXT != null, "pglNamedProgramLocalParameters4fvEXT not implemented");
					Delegates.pglNamedProgramLocalParameters4fvEXT(program, target, index, count, p_params);
					LogFunction("glNamedProgramLocalParameters4fvEXT({0}, {1}, {2}, {3}, {4})", program, LogEnumName(target), index, count, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNamedProgramLocalParameterI4iEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedProgramLocalParameterI4EXT(UInt32 program, Int32 target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w)
		{
			Debug.Assert(Delegates.pglNamedProgramLocalParameterI4iEXT != null, "pglNamedProgramLocalParameterI4iEXT not implemented");
			Delegates.pglNamedProgramLocalParameterI4iEXT(program, target, index, x, y, z, w);
			LogFunction("glNamedProgramLocalParameterI4iEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", program, LogEnumName(target), index, x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNamedProgramLocalParameterI4ivEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedProgramLocalParameterI4EXT(UInt32 program, Int32 target, UInt32 index, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglNamedProgramLocalParameterI4ivEXT != null, "pglNamedProgramLocalParameterI4ivEXT not implemented");
					Delegates.pglNamedProgramLocalParameterI4ivEXT(program, target, index, p_params);
					LogFunction("glNamedProgramLocalParameterI4ivEXT({0}, {1}, {2}, {3})", program, LogEnumName(target), index, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNamedProgramLocalParametersI4ivEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedProgramLocalParametersI4EXT(UInt32 program, Int32 target, UInt32 index, Int32 count, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglNamedProgramLocalParametersI4ivEXT != null, "pglNamedProgramLocalParametersI4ivEXT not implemented");
					Delegates.pglNamedProgramLocalParametersI4ivEXT(program, target, index, count, p_params);
					LogFunction("glNamedProgramLocalParametersI4ivEXT({0}, {1}, {2}, {3}, {4})", program, LogEnumName(target), index, count, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNamedProgramLocalParameterI4uiEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedProgramLocalParameterI4uiEXT(UInt32 program, Int32 target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w)
		{
			Debug.Assert(Delegates.pglNamedProgramLocalParameterI4uiEXT != null, "pglNamedProgramLocalParameterI4uiEXT not implemented");
			Delegates.pglNamedProgramLocalParameterI4uiEXT(program, target, index, x, y, z, w);
			LogFunction("glNamedProgramLocalParameterI4uiEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", program, LogEnumName(target), index, x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNamedProgramLocalParameterI4uivEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedProgramLocalParameterI4uiEXT(UInt32 program, Int32 target, UInt32 index, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglNamedProgramLocalParameterI4uivEXT != null, "pglNamedProgramLocalParameterI4uivEXT not implemented");
					Delegates.pglNamedProgramLocalParameterI4uivEXT(program, target, index, p_params);
					LogFunction("glNamedProgramLocalParameterI4uivEXT({0}, {1}, {2}, {3})", program, LogEnumName(target), index, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNamedProgramLocalParametersI4uivEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedProgramLocalParametersI4uiEXT(UInt32 program, Int32 target, UInt32 index, Int32 count, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglNamedProgramLocalParametersI4uivEXT != null, "pglNamedProgramLocalParametersI4uivEXT not implemented");
					Delegates.pglNamedProgramLocalParametersI4uivEXT(program, target, index, count, p_params);
					LogFunction("glNamedProgramLocalParametersI4uivEXT({0}, {1}, {2}, {3}, {4})", program, LogEnumName(target), index, count, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetNamedProgramLocalParameterIivEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetNamedProgramLocalParameterIEXT(UInt32 program, Int32 target, UInt32 index, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetNamedProgramLocalParameterIivEXT != null, "pglGetNamedProgramLocalParameterIivEXT not implemented");
					Delegates.pglGetNamedProgramLocalParameterIivEXT(program, target, index, p_params);
					LogFunction("glGetNamedProgramLocalParameterIivEXT({0}, {1}, {2}, {3})", program, LogEnumName(target), index, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetNamedProgramLocalParameterIuivEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetNamedProgramLocalParameterIEXT(UInt32 program, Int32 target, UInt32 index, [Out] UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetNamedProgramLocalParameterIuivEXT != null, "pglGetNamedProgramLocalParameterIuivEXT not implemented");
					Delegates.pglGetNamedProgramLocalParameterIuivEXT(program, target, index, p_params);
					LogFunction("glGetNamedProgramLocalParameterIuivEXT({0}, {1}, {2}, {3})", program, LogEnumName(target), index, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glEnableClientStateiEXT.
		/// </summary>
		/// <param name="array">
		/// A <see cref="T:EnableCap"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void EnableClientStateEXT(EnableCap array, UInt32 index)
		{
			Debug.Assert(Delegates.pglEnableClientStateiEXT != null, "pglEnableClientStateiEXT not implemented");
			Delegates.pglEnableClientStateiEXT((Int32)array, index);
			LogFunction("glEnableClientStateiEXT({0}, {1})", array, index);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDisableClientStateiEXT.
		/// </summary>
		/// <param name="array">
		/// A <see cref="T:EnableCap"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void DisableClientStateEXT(EnableCap array, UInt32 index)
		{
			Debug.Assert(Delegates.pglDisableClientStateiEXT != null, "pglDisableClientStateiEXT not implemented");
			Delegates.pglDisableClientStateiEXT((Int32)array, index);
			LogFunction("glDisableClientStateiEXT({0}, {1})", array, index);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPointeri_vEXT.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetPointerEXT(Int32 pname, UInt32 index, out IntPtr @params)
		{
			unsafe {
				fixed (IntPtr* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetPointeri_vEXT != null, "pglGetPointeri_vEXT not implemented");
					Delegates.pglGetPointeri_vEXT(pname, index, p_params);
					LogFunction("glGetPointeri_vEXT({0}, {1}, 0x{2})", LogEnumName(pname), index, @params.ToString("X8"));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPointeri_vEXT.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetPointerEXT(Int32 pname, UInt32 index, Object @params)
		{
			GCHandle pin_params = GCHandle.Alloc(@params, GCHandleType.Pinned);
			try {
				GetPointerEXT(pname, index, pin_params.AddrOfPinnedObject());
			} finally {
				pin_params.Free();
			}
		}

		/// <summary>
		/// Binding for glNamedProgramStringEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="len">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="string">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedProgramStringEXT(UInt32 program, Int32 target, Int32 format, Int32 len, IntPtr @string)
		{
			Debug.Assert(Delegates.pglNamedProgramStringEXT != null, "pglNamedProgramStringEXT not implemented");
			Delegates.pglNamedProgramStringEXT(program, target, format, len, @string);
			LogFunction("glNamedProgramStringEXT({0}, {1}, {2}, {3}, 0x{4})", program, LogEnumName(target), LogEnumName(format), len, @string.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNamedProgramStringEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="len">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="string">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedProgramStringEXT(UInt32 program, Int32 target, Int32 format, Int32 len, Object @string)
		{
			GCHandle pin_string = GCHandle.Alloc(@string, GCHandleType.Pinned);
			try {
				NamedProgramStringEXT(program, target, format, len, pin_string.AddrOfPinnedObject());
			} finally {
				pin_string.Free();
			}
		}

		/// <summary>
		/// Binding for glNamedProgramLocalParameter4dEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedProgramLocalParameter4EXT(UInt32 program, Int32 target, UInt32 index, double x, double y, double z, double w)
		{
			Debug.Assert(Delegates.pglNamedProgramLocalParameter4dEXT != null, "pglNamedProgramLocalParameter4dEXT not implemented");
			Delegates.pglNamedProgramLocalParameter4dEXT(program, target, index, x, y, z, w);
			LogFunction("glNamedProgramLocalParameter4dEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", program, LogEnumName(target), index, x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNamedProgramLocalParameter4dvEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedProgramLocalParameter4EXT(UInt32 program, Int32 target, UInt32 index, double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglNamedProgramLocalParameter4dvEXT != null, "pglNamedProgramLocalParameter4dvEXT not implemented");
					Delegates.pglNamedProgramLocalParameter4dvEXT(program, target, index, p_params);
					LogFunction("glNamedProgramLocalParameter4dvEXT({0}, {1}, {2}, {3})", program, LogEnumName(target), index, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNamedProgramLocalParameter4fEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedProgramLocalParameter4EXT(UInt32 program, Int32 target, UInt32 index, float x, float y, float z, float w)
		{
			Debug.Assert(Delegates.pglNamedProgramLocalParameter4fEXT != null, "pglNamedProgramLocalParameter4fEXT not implemented");
			Delegates.pglNamedProgramLocalParameter4fEXT(program, target, index, x, y, z, w);
			LogFunction("glNamedProgramLocalParameter4fEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", program, LogEnumName(target), index, x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNamedProgramLocalParameter4fvEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedProgramLocalParameter4EXT(UInt32 program, Int32 target, UInt32 index, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglNamedProgramLocalParameter4fvEXT != null, "pglNamedProgramLocalParameter4fvEXT not implemented");
					Delegates.pglNamedProgramLocalParameter4fvEXT(program, target, index, p_params);
					LogFunction("glNamedProgramLocalParameter4fvEXT({0}, {1}, {2}, {3})", program, LogEnumName(target), index, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetNamedProgramLocalParameterdvEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetNamedProgramLocalParameterEXT(UInt32 program, Int32 target, UInt32 index, [Out] double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetNamedProgramLocalParameterdvEXT != null, "pglGetNamedProgramLocalParameterdvEXT not implemented");
					Delegates.pglGetNamedProgramLocalParameterdvEXT(program, target, index, p_params);
					LogFunction("glGetNamedProgramLocalParameterdvEXT({0}, {1}, {2}, {3})", program, LogEnumName(target), index, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetNamedProgramLocalParameterfvEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetNamedProgramLocalParameterEXT(UInt32 program, Int32 target, UInt32 index, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetNamedProgramLocalParameterfvEXT != null, "pglGetNamedProgramLocalParameterfvEXT not implemented");
					Delegates.pglGetNamedProgramLocalParameterfvEXT(program, target, index, p_params);
					LogFunction("glGetNamedProgramLocalParameterfvEXT({0}, {1}, {2}, {3})", program, LogEnumName(target), index, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetNamedProgramivEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetNamedProgramEXT(UInt32 program, Int32 target, Int32 pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetNamedProgramivEXT != null, "pglGetNamedProgramivEXT not implemented");
					Delegates.pglGetNamedProgramivEXT(program, target, pname, p_params);
					LogFunction("glGetNamedProgramivEXT({0}, {1}, {2}, {3})", program, LogEnumName(target), LogEnumName(pname), @params);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetNamedProgramStringEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="string">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetNamedProgramStringEXT(UInt32 program, Int32 target, Int32 pname, IntPtr @string)
		{
			Debug.Assert(Delegates.pglGetNamedProgramStringEXT != null, "pglGetNamedProgramStringEXT not implemented");
			Delegates.pglGetNamedProgramStringEXT(program, target, pname, @string);
			LogFunction("glGetNamedProgramStringEXT({0}, {1}, {2}, 0x{3})", program, LogEnumName(target), LogEnumName(pname), @string.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetNamedProgramStringEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="string">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetNamedProgramStringEXT(UInt32 program, Int32 target, Int32 pname, Object @string)
		{
			GCHandle pin_string = GCHandle.Alloc(@string, GCHandleType.Pinned);
			try {
				GetNamedProgramStringEXT(program, target, pname, pin_string.AddrOfPinnedObject());
			} finally {
				pin_string.Free();
			}
		}

		/// <summary>
		/// Binding for glNamedRenderbufferStorageEXT.
		/// </summary>
		/// <param name="renderbuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedRenderbufferStorageEXT(UInt32 renderbuffer, Int32 internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglNamedRenderbufferStorageEXT != null, "pglNamedRenderbufferStorageEXT not implemented");
			Delegates.pglNamedRenderbufferStorageEXT(renderbuffer, internalformat, width, height);
			LogFunction("glNamedRenderbufferStorageEXT({0}, {1}, {2}, {3})", renderbuffer, LogEnumName(internalformat), width, height);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetNamedRenderbufferParameterivEXT.
		/// </summary>
		/// <param name="renderbuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetNamedRenderbufferParameterEXT(UInt32 renderbuffer, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetNamedRenderbufferParameterivEXT != null, "pglGetNamedRenderbufferParameterivEXT not implemented");
					Delegates.pglGetNamedRenderbufferParameterivEXT(renderbuffer, pname, p_params);
					LogFunction("glGetNamedRenderbufferParameterivEXT({0}, {1}, {2})", renderbuffer, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNamedRenderbufferStorageMultisampleEXT.
		/// </summary>
		/// <param name="renderbuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedRenderbufferStorageMultisampleEXT(UInt32 renderbuffer, Int32 samples, Int32 internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglNamedRenderbufferStorageMultisampleEXT != null, "pglNamedRenderbufferStorageMultisampleEXT not implemented");
			Delegates.pglNamedRenderbufferStorageMultisampleEXT(renderbuffer, samples, internalformat, width, height);
			LogFunction("glNamedRenderbufferStorageMultisampleEXT({0}, {1}, {2}, {3}, {4})", renderbuffer, samples, LogEnumName(internalformat), width, height);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNamedRenderbufferStorageMultisampleCoverageEXT.
		/// </summary>
		/// <param name="renderbuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="coverageSamples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="colorSamples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedRenderbufferStorageMultisampleCoverageEXT(UInt32 renderbuffer, Int32 coverageSamples, Int32 colorSamples, Int32 internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglNamedRenderbufferStorageMultisampleCoverageEXT != null, "pglNamedRenderbufferStorageMultisampleCoverageEXT not implemented");
			Delegates.pglNamedRenderbufferStorageMultisampleCoverageEXT(renderbuffer, coverageSamples, colorSamples, internalformat, width, height);
			LogFunction("glNamedRenderbufferStorageMultisampleCoverageEXT({0}, {1}, {2}, {3}, {4}, {5})", renderbuffer, coverageSamples, colorSamples, LogEnumName(internalformat), width, height);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCheckNamedFramebufferStatusEXT.
		/// </summary>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static Int32 CheckNamedFramebufferStatusEXT(UInt32 framebuffer, Int32 target)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglCheckNamedFramebufferStatusEXT != null, "pglCheckNamedFramebufferStatusEXT not implemented");
			retValue = Delegates.pglCheckNamedFramebufferStatusEXT(framebuffer, target);
			LogFunction("glCheckNamedFramebufferStatusEXT({0}, {1}) = {2}", framebuffer, LogEnumName(target), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glNamedFramebufferTexture1DEXT.
		/// </summary>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="textarget">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedFramebufferTexture1DEXT(UInt32 framebuffer, Int32 attachment, TextureTarget textarget, UInt32 texture, Int32 level)
		{
			Debug.Assert(Delegates.pglNamedFramebufferTexture1DEXT != null, "pglNamedFramebufferTexture1DEXT not implemented");
			Delegates.pglNamedFramebufferTexture1DEXT(framebuffer, attachment, (Int32)textarget, texture, level);
			LogFunction("glNamedFramebufferTexture1DEXT({0}, {1}, {2}, {3}, {4})", framebuffer, LogEnumName(attachment), textarget, texture, level);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNamedFramebufferTexture2DEXT.
		/// </summary>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="textarget">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedFramebufferTexture2DEXT(UInt32 framebuffer, Int32 attachment, TextureTarget textarget, UInt32 texture, Int32 level)
		{
			Debug.Assert(Delegates.pglNamedFramebufferTexture2DEXT != null, "pglNamedFramebufferTexture2DEXT not implemented");
			Delegates.pglNamedFramebufferTexture2DEXT(framebuffer, attachment, (Int32)textarget, texture, level);
			LogFunction("glNamedFramebufferTexture2DEXT({0}, {1}, {2}, {3}, {4})", framebuffer, LogEnumName(attachment), textarget, texture, level);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNamedFramebufferTexture3DEXT.
		/// </summary>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="textarget">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedFramebufferTexture3DEXT(UInt32 framebuffer, Int32 attachment, TextureTarget textarget, UInt32 texture, Int32 level, Int32 zoffset)
		{
			Debug.Assert(Delegates.pglNamedFramebufferTexture3DEXT != null, "pglNamedFramebufferTexture3DEXT not implemented");
			Delegates.pglNamedFramebufferTexture3DEXT(framebuffer, attachment, (Int32)textarget, texture, level, zoffset);
			LogFunction("glNamedFramebufferTexture3DEXT({0}, {1}, {2}, {3}, {4}, {5})", framebuffer, LogEnumName(attachment), textarget, texture, level, zoffset);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNamedFramebufferRenderbufferEXT.
		/// </summary>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="renderbuffertarget">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="renderbuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedFramebufferRenderbufferEXT(UInt32 framebuffer, Int32 attachment, Int32 renderbuffertarget, UInt32 renderbuffer)
		{
			Debug.Assert(Delegates.pglNamedFramebufferRenderbufferEXT != null, "pglNamedFramebufferRenderbufferEXT not implemented");
			Delegates.pglNamedFramebufferRenderbufferEXT(framebuffer, attachment, renderbuffertarget, renderbuffer);
			LogFunction("glNamedFramebufferRenderbufferEXT({0}, {1}, {2}, {3})", framebuffer, LogEnumName(attachment), LogEnumName(renderbuffertarget), renderbuffer);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetNamedFramebufferAttachmentParameterivEXT.
		/// </summary>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetNamedFramebufferAttachmentParameterEXT(UInt32 framebuffer, Int32 attachment, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetNamedFramebufferAttachmentParameterivEXT != null, "pglGetNamedFramebufferAttachmentParameterivEXT not implemented");
					Delegates.pglGetNamedFramebufferAttachmentParameterivEXT(framebuffer, attachment, pname, p_params);
					LogFunction("glGetNamedFramebufferAttachmentParameterivEXT({0}, {1}, {2}, {3})", framebuffer, LogEnumName(attachment), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGenerateTextureMipmapEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GenerateTextureMipmapEXT(UInt32 texture, TextureTarget target)
		{
			Debug.Assert(Delegates.pglGenerateTextureMipmapEXT != null, "pglGenerateTextureMipmapEXT not implemented");
			Delegates.pglGenerateTextureMipmapEXT(texture, (Int32)target);
			LogFunction("glGenerateTextureMipmapEXT({0}, {1})", texture, target);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGenerateMultiTexMipmapEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GenerateMultiTexMipmapEXT(Int32 texunit, TextureTarget target)
		{
			Debug.Assert(Delegates.pglGenerateMultiTexMipmapEXT != null, "pglGenerateMultiTexMipmapEXT not implemented");
			Delegates.pglGenerateMultiTexMipmapEXT(texunit, (Int32)target);
			LogFunction("glGenerateMultiTexMipmapEXT({0}, {1})", LogEnumName(texunit), target);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glFramebufferDrawBufferEXT.
		/// </summary>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="mode">
		/// A <see cref="T:DrawBufferMode"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void FramebufferDrawBufferEXT(UInt32 framebuffer, DrawBufferMode mode)
		{
			Debug.Assert(Delegates.pglFramebufferDrawBufferEXT != null, "pglFramebufferDrawBufferEXT not implemented");
			Delegates.pglFramebufferDrawBufferEXT(framebuffer, (Int32)mode);
			LogFunction("glFramebufferDrawBufferEXT({0}, {1})", framebuffer, mode);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glFramebufferDrawBuffersEXT.
		/// </summary>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="bufs">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void FramebufferDrawBuffersEXT(UInt32 framebuffer, Int32[] bufs)
		{
			unsafe {
				fixed (Int32* p_bufs = bufs)
				{
					Debug.Assert(Delegates.pglFramebufferDrawBuffersEXT != null, "pglFramebufferDrawBuffersEXT not implemented");
					Delegates.pglFramebufferDrawBuffersEXT(framebuffer, (Int32)bufs.Length, p_bufs);
					LogFunction("glFramebufferDrawBuffersEXT({0}, {1}, {2})", framebuffer, bufs.Length, LogEnumName(bufs));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glFramebufferReadBufferEXT.
		/// </summary>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="mode">
		/// A <see cref="T:ReadBufferMode"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void FramebufferReadBufferEXT(UInt32 framebuffer, ReadBufferMode mode)
		{
			Debug.Assert(Delegates.pglFramebufferReadBufferEXT != null, "pglFramebufferReadBufferEXT not implemented");
			Delegates.pglFramebufferReadBufferEXT(framebuffer, (Int32)mode);
			LogFunction("glFramebufferReadBufferEXT({0}, {1})", framebuffer, mode);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetFramebufferParameterivEXT.
		/// </summary>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetFramebufferParameterEXT(UInt32 framebuffer, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetFramebufferParameterivEXT != null, "pglGetFramebufferParameterivEXT not implemented");
					Delegates.pglGetFramebufferParameterivEXT(framebuffer, pname, p_params);
					LogFunction("glGetFramebufferParameterivEXT({0}, {1}, {2})", framebuffer, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNamedCopyBufferSubDataEXT.
		/// </summary>
		/// <param name="readBuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="writeBuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="readOffset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="writeOffset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedCopyBufferSubDataEXT(UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, UInt32 size)
		{
			Debug.Assert(Delegates.pglNamedCopyBufferSubDataEXT != null, "pglNamedCopyBufferSubDataEXT not implemented");
			Delegates.pglNamedCopyBufferSubDataEXT(readBuffer, writeBuffer, readOffset, writeOffset, size);
			LogFunction("glNamedCopyBufferSubDataEXT({0}, {1}, 0x{2}, 0x{3}, {4})", readBuffer, writeBuffer, readOffset.ToString("X8"), writeOffset.ToString("X8"), size);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNamedFramebufferTextureEXT.
		/// </summary>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedFramebufferTextureEXT(UInt32 framebuffer, Int32 attachment, UInt32 texture, Int32 level)
		{
			Debug.Assert(Delegates.pglNamedFramebufferTextureEXT != null, "pglNamedFramebufferTextureEXT not implemented");
			Delegates.pglNamedFramebufferTextureEXT(framebuffer, attachment, texture, level);
			LogFunction("glNamedFramebufferTextureEXT({0}, {1}, {2}, {3})", framebuffer, LogEnumName(attachment), texture, level);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNamedFramebufferTextureLayerEXT.
		/// </summary>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="layer">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedFramebufferTextureLayerEXT(UInt32 framebuffer, Int32 attachment, UInt32 texture, Int32 level, Int32 layer)
		{
			Debug.Assert(Delegates.pglNamedFramebufferTextureLayerEXT != null, "pglNamedFramebufferTextureLayerEXT not implemented");
			Delegates.pglNamedFramebufferTextureLayerEXT(framebuffer, attachment, texture, level, layer);
			LogFunction("glNamedFramebufferTextureLayerEXT({0}, {1}, {2}, {3}, {4})", framebuffer, LogEnumName(attachment), texture, level, layer);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNamedFramebufferTextureFaceEXT.
		/// </summary>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="face">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedFramebufferTextureFaceEXT(UInt32 framebuffer, Int32 attachment, UInt32 texture, Int32 level, TextureTarget face)
		{
			Debug.Assert(Delegates.pglNamedFramebufferTextureFaceEXT != null, "pglNamedFramebufferTextureFaceEXT not implemented");
			Delegates.pglNamedFramebufferTextureFaceEXT(framebuffer, attachment, texture, level, (Int32)face);
			LogFunction("glNamedFramebufferTextureFaceEXT({0}, {1}, {2}, {3}, {4})", framebuffer, LogEnumName(attachment), texture, level, face);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureRenderbufferEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="renderbuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void TextureRenderbufferEXT(UInt32 texture, TextureTarget target, UInt32 renderbuffer)
		{
			Debug.Assert(Delegates.pglTextureRenderbufferEXT != null, "pglTextureRenderbufferEXT not implemented");
			Delegates.pglTextureRenderbufferEXT(texture, (Int32)target, renderbuffer);
			LogFunction("glTextureRenderbufferEXT({0}, {1}, {2})", texture, target, renderbuffer);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexRenderbufferEXT.
		/// </summary>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="renderbuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void MultiTexRenderbufferEXT(Int32 texunit, TextureTarget target, UInt32 renderbuffer)
		{
			Debug.Assert(Delegates.pglMultiTexRenderbufferEXT != null, "pglMultiTexRenderbufferEXT not implemented");
			Delegates.pglMultiTexRenderbufferEXT(texunit, (Int32)target, renderbuffer);
			LogFunction("glMultiTexRenderbufferEXT({0}, {1}, {2})", LogEnumName(texunit), target, renderbuffer);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexArrayVertexOffsetEXT.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:VertexPointerType"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void VertexArrayVertexOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 size, VertexPointerType type, Int32 stride, IntPtr offset)
		{
			Debug.Assert(Delegates.pglVertexArrayVertexOffsetEXT != null, "pglVertexArrayVertexOffsetEXT not implemented");
			Delegates.pglVertexArrayVertexOffsetEXT(vaobj, buffer, size, (Int32)type, stride, offset);
			LogFunction("glVertexArrayVertexOffsetEXT({0}, {1}, {2}, {3}, {4}, 0x{5})", vaobj, buffer, size, type, stride, offset.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexArrayColorOffsetEXT.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:ColorPointerType"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void VertexArrayColorOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 size, ColorPointerType type, Int32 stride, IntPtr offset)
		{
			Debug.Assert(Delegates.pglVertexArrayColorOffsetEXT != null, "pglVertexArrayColorOffsetEXT not implemented");
			Delegates.pglVertexArrayColorOffsetEXT(vaobj, buffer, size, (Int32)type, stride, offset);
			LogFunction("glVertexArrayColorOffsetEXT({0}, {1}, {2}, {3}, {4}, 0x{5})", vaobj, buffer, size, type, stride, offset.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexArrayEdgeFlagOffsetEXT.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void VertexArrayEdgeFlagOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 stride, IntPtr offset)
		{
			Debug.Assert(Delegates.pglVertexArrayEdgeFlagOffsetEXT != null, "pglVertexArrayEdgeFlagOffsetEXT not implemented");
			Delegates.pglVertexArrayEdgeFlagOffsetEXT(vaobj, buffer, stride, offset);
			LogFunction("glVertexArrayEdgeFlagOffsetEXT({0}, {1}, {2}, 0x{3})", vaobj, buffer, stride, offset.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexArrayIndexOffsetEXT.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:IndexPointerType"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void VertexArrayIndexOffsetEXT(UInt32 vaobj, UInt32 buffer, IndexPointerType type, Int32 stride, IntPtr offset)
		{
			Debug.Assert(Delegates.pglVertexArrayIndexOffsetEXT != null, "pglVertexArrayIndexOffsetEXT not implemented");
			Delegates.pglVertexArrayIndexOffsetEXT(vaobj, buffer, (Int32)type, stride, offset);
			LogFunction("glVertexArrayIndexOffsetEXT({0}, {1}, {2}, {3}, 0x{4})", vaobj, buffer, type, stride, offset.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexArrayNormalOffsetEXT.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:NormalPointerType"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void VertexArrayNormalOffsetEXT(UInt32 vaobj, UInt32 buffer, NormalPointerType type, Int32 stride, IntPtr offset)
		{
			Debug.Assert(Delegates.pglVertexArrayNormalOffsetEXT != null, "pglVertexArrayNormalOffsetEXT not implemented");
			Delegates.pglVertexArrayNormalOffsetEXT(vaobj, buffer, (Int32)type, stride, offset);
			LogFunction("glVertexArrayNormalOffsetEXT({0}, {1}, {2}, {3}, 0x{4})", vaobj, buffer, type, stride, offset.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexArrayTexCoordOffsetEXT.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:TexCoordPointerType"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void VertexArrayTexCoordOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 size, TexCoordPointerType type, Int32 stride, IntPtr offset)
		{
			Debug.Assert(Delegates.pglVertexArrayTexCoordOffsetEXT != null, "pglVertexArrayTexCoordOffsetEXT not implemented");
			Delegates.pglVertexArrayTexCoordOffsetEXT(vaobj, buffer, size, (Int32)type, stride, offset);
			LogFunction("glVertexArrayTexCoordOffsetEXT({0}, {1}, {2}, {3}, {4}, 0x{5})", vaobj, buffer, size, type, stride, offset.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexArrayMultiTexCoordOffsetEXT.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="texunit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:TexCoordPointerType"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void VertexArrayMultiTexCoordOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 texunit, Int32 size, TexCoordPointerType type, Int32 stride, IntPtr offset)
		{
			Debug.Assert(Delegates.pglVertexArrayMultiTexCoordOffsetEXT != null, "pglVertexArrayMultiTexCoordOffsetEXT not implemented");
			Delegates.pglVertexArrayMultiTexCoordOffsetEXT(vaobj, buffer, texunit, size, (Int32)type, stride, offset);
			LogFunction("glVertexArrayMultiTexCoordOffsetEXT({0}, {1}, {2}, {3}, {4}, {5}, 0x{6})", vaobj, buffer, LogEnumName(texunit), size, type, stride, offset.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexArrayFogCoordOffsetEXT.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:FogCoordinatePointerType"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void VertexArrayFogCoordOffsetEXT(UInt32 vaobj, UInt32 buffer, FogCoordinatePointerType type, Int32 stride, IntPtr offset)
		{
			Debug.Assert(Delegates.pglVertexArrayFogCoordOffsetEXT != null, "pglVertexArrayFogCoordOffsetEXT not implemented");
			Delegates.pglVertexArrayFogCoordOffsetEXT(vaobj, buffer, (Int32)type, stride, offset);
			LogFunction("glVertexArrayFogCoordOffsetEXT({0}, {1}, {2}, {3}, 0x{4})", vaobj, buffer, type, stride, offset.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexArraySecondaryColorOffsetEXT.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:ColorPointerType"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void VertexArraySecondaryColorOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 size, ColorPointerType type, Int32 stride, IntPtr offset)
		{
			Debug.Assert(Delegates.pglVertexArraySecondaryColorOffsetEXT != null, "pglVertexArraySecondaryColorOffsetEXT not implemented");
			Delegates.pglVertexArraySecondaryColorOffsetEXT(vaobj, buffer, size, (Int32)type, stride, offset);
			LogFunction("glVertexArraySecondaryColorOffsetEXT({0}, {1}, {2}, {3}, {4}, 0x{5})", vaobj, buffer, size, type, stride, offset.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexArrayVertexAttribOffsetEXT.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="normalized">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void VertexArrayVertexAttribOffsetEXT(UInt32 vaobj, UInt32 buffer, UInt32 index, Int32 size, Int32 type, bool normalized, Int32 stride, IntPtr offset)
		{
			Debug.Assert(Delegates.pglVertexArrayVertexAttribOffsetEXT != null, "pglVertexArrayVertexAttribOffsetEXT not implemented");
			Delegates.pglVertexArrayVertexAttribOffsetEXT(vaobj, buffer, index, size, type, normalized, stride, offset);
			LogFunction("glVertexArrayVertexAttribOffsetEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, 0x{7})", vaobj, buffer, index, size, LogEnumName(type), normalized, stride, offset.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexArrayVertexAttribIOffsetEXT.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void VertexArrayVertexAttribIOffsetEXT(UInt32 vaobj, UInt32 buffer, UInt32 index, Int32 size, Int32 type, Int32 stride, IntPtr offset)
		{
			Debug.Assert(Delegates.pglVertexArrayVertexAttribIOffsetEXT != null, "pglVertexArrayVertexAttribIOffsetEXT not implemented");
			Delegates.pglVertexArrayVertexAttribIOffsetEXT(vaobj, buffer, index, size, type, stride, offset);
			LogFunction("glVertexArrayVertexAttribIOffsetEXT({0}, {1}, {2}, {3}, {4}, {5}, 0x{6})", vaobj, buffer, index, size, LogEnumName(type), stride, offset.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glEnableVertexArrayEXT.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="array">
		/// A <see cref="T:EnableCap"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void EnableVertexArrayEXT(UInt32 vaobj, EnableCap array)
		{
			Debug.Assert(Delegates.pglEnableVertexArrayEXT != null, "pglEnableVertexArrayEXT not implemented");
			Delegates.pglEnableVertexArrayEXT(vaobj, (Int32)array);
			LogFunction("glEnableVertexArrayEXT({0}, {1})", vaobj, array);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDisableVertexArrayEXT.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="array">
		/// A <see cref="T:EnableCap"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void DisableVertexArrayEXT(UInt32 vaobj, EnableCap array)
		{
			Debug.Assert(Delegates.pglDisableVertexArrayEXT != null, "pglDisableVertexArrayEXT not implemented");
			Delegates.pglDisableVertexArrayEXT(vaobj, (Int32)array);
			LogFunction("glDisableVertexArrayEXT({0}, {1})", vaobj, array);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glEnableVertexArrayAttribEXT.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void EnableVertexArrayAttribEXT(UInt32 vaobj, UInt32 index)
		{
			Debug.Assert(Delegates.pglEnableVertexArrayAttribEXT != null, "pglEnableVertexArrayAttribEXT not implemented");
			Delegates.pglEnableVertexArrayAttribEXT(vaobj, index);
			LogFunction("glEnableVertexArrayAttribEXT({0}, {1})", vaobj, index);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDisableVertexArrayAttribEXT.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void DisableVertexArrayAttribEXT(UInt32 vaobj, UInt32 index)
		{
			Debug.Assert(Delegates.pglDisableVertexArrayAttribEXT != null, "pglDisableVertexArrayAttribEXT not implemented");
			Delegates.pglDisableVertexArrayAttribEXT(vaobj, index);
			LogFunction("glDisableVertexArrayAttribEXT({0}, {1})", vaobj, index);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetVertexArrayIntegervEXT.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetVertexArrayIntegerEXT(UInt32 vaobj, Int32 pname, [Out] Int32[] param)
		{
			unsafe {
				fixed (Int32* p_param = param)
				{
					Debug.Assert(Delegates.pglGetVertexArrayIntegervEXT != null, "pglGetVertexArrayIntegervEXT not implemented");
					Delegates.pglGetVertexArrayIntegervEXT(vaobj, pname, p_param);
					LogFunction("glGetVertexArrayIntegervEXT({0}, {1}, {2})", vaobj, LogEnumName(pname), LogValue(param));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetVertexArrayPointervEXT.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetVertexArrayPointerEXT(UInt32 vaobj, Int32 pname, out IntPtr param)
		{
			unsafe {
				fixed (IntPtr* p_param = &param)
				{
					Debug.Assert(Delegates.pglGetVertexArrayPointervEXT != null, "pglGetVertexArrayPointervEXT not implemented");
					Delegates.pglGetVertexArrayPointervEXT(vaobj, pname, p_param);
					LogFunction("glGetVertexArrayPointervEXT({0}, {1}, 0x{2})", vaobj, LogEnumName(pname), param.ToString("X8"));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetVertexArrayPointervEXT.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetVertexArrayPointerEXT(UInt32 vaobj, Int32 pname, Object param)
		{
			GCHandle pin_param = GCHandle.Alloc(param, GCHandleType.Pinned);
			try {
				GetVertexArrayPointerEXT(vaobj, pname, pin_param.AddrOfPinnedObject());
			} finally {
				pin_param.Free();
			}
		}

		/// <summary>
		/// Binding for glGetVertexArrayIntegeri_vEXT.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetVertexArrayIntegerEXT(UInt32 vaobj, UInt32 index, Int32 pname, [Out] Int32[] param)
		{
			unsafe {
				fixed (Int32* p_param = param)
				{
					Debug.Assert(Delegates.pglGetVertexArrayIntegeri_vEXT != null, "pglGetVertexArrayIntegeri_vEXT not implemented");
					Delegates.pglGetVertexArrayIntegeri_vEXT(vaobj, index, pname, p_param);
					LogFunction("glGetVertexArrayIntegeri_vEXT({0}, {1}, {2}, {3})", vaobj, index, LogEnumName(pname), LogValue(param));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetVertexArrayPointeri_vEXT.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetVertexArrayPointerEXT(UInt32 vaobj, UInt32 index, Int32 pname, [Out] IntPtr[] param)
		{
			unsafe {
				fixed (IntPtr* p_param = param)
				{
					Debug.Assert(Delegates.pglGetVertexArrayPointeri_vEXT != null, "pglGetVertexArrayPointeri_vEXT not implemented");
					Delegates.pglGetVertexArrayPointeri_vEXT(vaobj, index, pname, p_param);
					LogFunction("glGetVertexArrayPointeri_vEXT({0}, {1}, {2}, {3})", vaobj, index, LogEnumName(pname), LogValue(param));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMapNamedBufferRangeEXT.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="access">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static IntPtr MapNamedBufferRangeEXT(UInt32 buffer, IntPtr offset, UInt32 length, UInt32 access)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglMapNamedBufferRangeEXT != null, "pglMapNamedBufferRangeEXT not implemented");
			retValue = Delegates.pglMapNamedBufferRangeEXT(buffer, offset, length, access);
			LogFunction("glMapNamedBufferRangeEXT({0}, 0x{1}, {2}, {3}) = {4}", buffer, offset.ToString("X8"), length, access, retValue.ToString("X8"));
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glFlushMappedNamedBufferRangeEXT.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void FlushMappedNamedBufferRangeEXT(UInt32 buffer, IntPtr offset, UInt32 length)
		{
			Debug.Assert(Delegates.pglFlushMappedNamedBufferRangeEXT != null, "pglFlushMappedNamedBufferRangeEXT not implemented");
			Delegates.pglFlushMappedNamedBufferRangeEXT(buffer, offset, length);
			LogFunction("glFlushMappedNamedBufferRangeEXT({0}, 0x{1}, {2})", buffer, offset.ToString("X8"), length);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glClearNamedBufferDataEXT.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void ClearNamedBufferDataEXT(UInt32 buffer, Int32 internalformat, PixelFormat format, PixelType type, IntPtr data)
		{
			Debug.Assert(Delegates.pglClearNamedBufferDataEXT != null, "pglClearNamedBufferDataEXT not implemented");
			Delegates.pglClearNamedBufferDataEXT(buffer, internalformat, (Int32)format, (Int32)type, data);
			LogFunction("glClearNamedBufferDataEXT({0}, {1}, {2}, {3}, 0x{4})", buffer, LogEnumName(internalformat), format, type, data.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glClearNamedBufferDataEXT.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void ClearNamedBufferDataEXT(UInt32 buffer, Int32 internalformat, PixelFormat format, PixelType type, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				ClearNamedBufferDataEXT(buffer, internalformat, format, type, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// Binding for glClearNamedBufferSubDataEXT.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void ClearNamedBufferSubDataEXT(UInt32 buffer, Int32 internalformat, UInt32 offset, UInt32 size, PixelFormat format, PixelType type, IntPtr data)
		{
			Debug.Assert(Delegates.pglClearNamedBufferSubDataEXT != null, "pglClearNamedBufferSubDataEXT not implemented");
			Delegates.pglClearNamedBufferSubDataEXT(buffer, internalformat, offset, size, (Int32)format, (Int32)type, data);
			LogFunction("glClearNamedBufferSubDataEXT({0}, {1}, {2}, {3}, {4}, {5}, 0x{6})", buffer, LogEnumName(internalformat), offset, size, format, type, data.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glClearNamedBufferSubDataEXT.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void ClearNamedBufferSubDataEXT(UInt32 buffer, Int32 internalformat, UInt32 offset, UInt32 size, PixelFormat format, PixelType type, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				ClearNamedBufferSubDataEXT(buffer, internalformat, offset, size, format, type, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// Binding for glNamedFramebufferParameteriEXT.
		/// </summary>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedFramebufferParameterEXT(UInt32 framebuffer, Int32 pname, Int32 param)
		{
			Debug.Assert(Delegates.pglNamedFramebufferParameteriEXT != null, "pglNamedFramebufferParameteriEXT not implemented");
			Delegates.pglNamedFramebufferParameteriEXT(framebuffer, pname, param);
			LogFunction("glNamedFramebufferParameteriEXT({0}, {1}, {2})", framebuffer, LogEnumName(pname), param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetNamedFramebufferParameterivEXT.
		/// </summary>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void GetNamedFramebufferParameterEXT(UInt32 framebuffer, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetNamedFramebufferParameterivEXT != null, "pglGetNamedFramebufferParameterivEXT not implemented");
					Delegates.pglGetNamedFramebufferParameterivEXT(framebuffer, pname, p_params);
					LogFunction("glGetNamedFramebufferParameterivEXT({0}, {1}, {2})", framebuffer, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform1dEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void ProgramUniform1EXT(UInt32 program, Int32 location, double x)
		{
			Debug.Assert(Delegates.pglProgramUniform1dEXT != null, "pglProgramUniform1dEXT not implemented");
			Delegates.pglProgramUniform1dEXT(program, location, x);
			LogFunction("glProgramUniform1dEXT({0}, {1}, {2})", program, location, x);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform2dEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void ProgramUniform2EXT(UInt32 program, Int32 location, double x, double y)
		{
			Debug.Assert(Delegates.pglProgramUniform2dEXT != null, "pglProgramUniform2dEXT not implemented");
			Delegates.pglProgramUniform2dEXT(program, location, x, y);
			LogFunction("glProgramUniform2dEXT({0}, {1}, {2}, {3})", program, location, x, y);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform3dEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void ProgramUniform3EXT(UInt32 program, Int32 location, double x, double y, double z)
		{
			Debug.Assert(Delegates.pglProgramUniform3dEXT != null, "pglProgramUniform3dEXT not implemented");
			Delegates.pglProgramUniform3dEXT(program, location, x, y, z);
			LogFunction("glProgramUniform3dEXT({0}, {1}, {2}, {3}, {4})", program, location, x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform4dEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void ProgramUniform4EXT(UInt32 program, Int32 location, double x, double y, double z, double w)
		{
			Debug.Assert(Delegates.pglProgramUniform4dEXT != null, "pglProgramUniform4dEXT not implemented");
			Delegates.pglProgramUniform4dEXT(program, location, x, y, z, w);
			LogFunction("glProgramUniform4dEXT({0}, {1}, {2}, {3}, {4}, {5})", program, location, x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform1dvEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void ProgramUniform1EXT(UInt32 program, Int32 location, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform1dvEXT != null, "pglProgramUniform1dvEXT not implemented");
					Delegates.pglProgramUniform1dvEXT(program, location, (Int32)value.Length, p_value);
					LogFunction("glProgramUniform1dvEXT({0}, {1}, {2}, {3})", program, location, value.Length, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform2dvEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void ProgramUniform2EXT(UInt32 program, Int32 location, Int32 count, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform2dvEXT != null, "pglProgramUniform2dvEXT not implemented");
					Delegates.pglProgramUniform2dvEXT(program, location, count, p_value);
					LogFunction("glProgramUniform2dvEXT({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform3dvEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void ProgramUniform3EXT(UInt32 program, Int32 location, Int32 count, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform3dvEXT != null, "pglProgramUniform3dvEXT not implemented");
					Delegates.pglProgramUniform3dvEXT(program, location, count, p_value);
					LogFunction("glProgramUniform3dvEXT({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform4dvEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void ProgramUniform4EXT(UInt32 program, Int32 location, Int32 count, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform4dvEXT != null, "pglProgramUniform4dvEXT not implemented");
					Delegates.pglProgramUniform4dvEXT(program, location, count, p_value);
					LogFunction("glProgramUniform4dvEXT({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix2dvEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void ProgramUniformMatrix2EXT(UInt32 program, Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix2dvEXT != null, "pglProgramUniformMatrix2dvEXT not implemented");
					Delegates.pglProgramUniformMatrix2dvEXT(program, location, count, transpose, p_value);
					LogFunction("glProgramUniformMatrix2dvEXT({0}, {1}, {2}, {3}, {4})", program, location, count, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix3dvEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void ProgramUniformMatrix3EXT(UInt32 program, Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix3dvEXT != null, "pglProgramUniformMatrix3dvEXT not implemented");
					Delegates.pglProgramUniformMatrix3dvEXT(program, location, count, transpose, p_value);
					LogFunction("glProgramUniformMatrix3dvEXT({0}, {1}, {2}, {3}, {4})", program, location, count, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix4dvEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void ProgramUniformMatrix4EXT(UInt32 program, Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix4dvEXT != null, "pglProgramUniformMatrix4dvEXT not implemented");
					Delegates.pglProgramUniformMatrix4dvEXT(program, location, count, transpose, p_value);
					LogFunction("glProgramUniformMatrix4dvEXT({0}, {1}, {2}, {3}, {4})", program, location, count, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix2x3dvEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void ProgramUniformMatrix2x3EXT(UInt32 program, Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix2x3dvEXT != null, "pglProgramUniformMatrix2x3dvEXT not implemented");
					Delegates.pglProgramUniformMatrix2x3dvEXT(program, location, count, transpose, p_value);
					LogFunction("glProgramUniformMatrix2x3dvEXT({0}, {1}, {2}, {3}, {4})", program, location, count, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix2x4dvEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void ProgramUniformMatrix2x4EXT(UInt32 program, Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix2x4dvEXT != null, "pglProgramUniformMatrix2x4dvEXT not implemented");
					Delegates.pglProgramUniformMatrix2x4dvEXT(program, location, count, transpose, p_value);
					LogFunction("glProgramUniformMatrix2x4dvEXT({0}, {1}, {2}, {3}, {4})", program, location, count, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix3x2dvEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void ProgramUniformMatrix3x2EXT(UInt32 program, Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix3x2dvEXT != null, "pglProgramUniformMatrix3x2dvEXT not implemented");
					Delegates.pglProgramUniformMatrix3x2dvEXT(program, location, count, transpose, p_value);
					LogFunction("glProgramUniformMatrix3x2dvEXT({0}, {1}, {2}, {3}, {4})", program, location, count, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix3x4dvEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void ProgramUniformMatrix3x4EXT(UInt32 program, Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix3x4dvEXT != null, "pglProgramUniformMatrix3x4dvEXT not implemented");
					Delegates.pglProgramUniformMatrix3x4dvEXT(program, location, count, transpose, p_value);
					LogFunction("glProgramUniformMatrix3x4dvEXT({0}, {1}, {2}, {3}, {4})", program, location, count, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix4x2dvEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void ProgramUniformMatrix4x2EXT(UInt32 program, Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix4x2dvEXT != null, "pglProgramUniformMatrix4x2dvEXT not implemented");
					Delegates.pglProgramUniformMatrix4x2dvEXT(program, location, count, transpose, p_value);
					LogFunction("glProgramUniformMatrix4x2dvEXT({0}, {1}, {2}, {3}, {4})", program, location, count, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix4x3dvEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void ProgramUniformMatrix4x3EXT(UInt32 program, Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix4x3dvEXT != null, "pglProgramUniformMatrix4x3dvEXT not implemented");
					Delegates.pglProgramUniformMatrix4x3dvEXT(program, location, count, transpose, p_value);
					LogFunction("glProgramUniformMatrix4x3dvEXT({0}, {1}, {2}, {3}, {4})", program, location, count, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureBufferRangeEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void TextureBufferRangeEXT(UInt32 texture, TextureTarget target, Int32 internalformat, UInt32 buffer, IntPtr offset, UInt32 size)
		{
			Debug.Assert(Delegates.pglTextureBufferRangeEXT != null, "pglTextureBufferRangeEXT not implemented");
			Delegates.pglTextureBufferRangeEXT(texture, (Int32)target, internalformat, buffer, offset, size);
			LogFunction("glTextureBufferRangeEXT({0}, {1}, {2}, {3}, 0x{4}, {5})", texture, target, LogEnumName(internalformat), buffer, offset.ToString("X8"), size);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureStorage1DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="levels">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		public static void TextureStorage1DEXT(UInt32 texture, Int32 target, Int32 levels, Int32 internalformat, Int32 width)
		{
			Debug.Assert(Delegates.pglTextureStorage1DEXT != null, "pglTextureStorage1DEXT not implemented");
			Delegates.pglTextureStorage1DEXT(texture, target, levels, internalformat, width);
			LogFunction("glTextureStorage1DEXT({0}, {1}, {2}, {3}, {4})", texture, LogEnumName(target), levels, LogEnumName(internalformat), width);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureStorage2DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="levels">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		public static void TextureStorage2DEXT(UInt32 texture, Int32 target, Int32 levels, Int32 internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglTextureStorage2DEXT != null, "pglTextureStorage2DEXT not implemented");
			Delegates.pglTextureStorage2DEXT(texture, target, levels, internalformat, width, height);
			LogFunction("glTextureStorage2DEXT({0}, {1}, {2}, {3}, {4}, {5})", texture, LogEnumName(target), levels, LogEnumName(internalformat), width, height);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureStorage3DEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="levels">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		public static void TextureStorage3DEXT(UInt32 texture, Int32 target, Int32 levels, Int32 internalformat, Int32 width, Int32 height, Int32 depth)
		{
			Debug.Assert(Delegates.pglTextureStorage3DEXT != null, "pglTextureStorage3DEXT not implemented");
			Delegates.pglTextureStorage3DEXT(texture, target, levels, internalformat, width, height, depth);
			LogFunction("glTextureStorage3DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", texture, LogEnumName(target), levels, LogEnumName(internalformat), width, height, depth);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureStorage2DMultisampleEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fixedsamplelocations">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void TextureStorage2DMultisampleEXT(UInt32 texture, TextureTarget target, Int32 samples, Int32 internalformat, Int32 width, Int32 height, bool fixedsamplelocations)
		{
			Debug.Assert(Delegates.pglTextureStorage2DMultisampleEXT != null, "pglTextureStorage2DMultisampleEXT not implemented");
			Delegates.pglTextureStorage2DMultisampleEXT(texture, (Int32)target, samples, internalformat, width, height, fixedsamplelocations);
			LogFunction("glTextureStorage2DMultisampleEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", texture, target, samples, LogEnumName(internalformat), width, height, fixedsamplelocations);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureStorage3DMultisampleEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fixedsamplelocations">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void TextureStorage3DMultisampleEXT(UInt32 texture, Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations)
		{
			Debug.Assert(Delegates.pglTextureStorage3DMultisampleEXT != null, "pglTextureStorage3DMultisampleEXT not implemented");
			Delegates.pglTextureStorage3DMultisampleEXT(texture, target, samples, internalformat, width, height, depth, fixedsamplelocations);
			LogFunction("glTextureStorage3DMultisampleEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", texture, LogEnumName(target), samples, LogEnumName(internalformat), width, height, depth, fixedsamplelocations);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexArrayBindVertexBufferEXT.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="bindingindex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void VertexArrayBindVertexBufferEXT(UInt32 vaobj, UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride)
		{
			Debug.Assert(Delegates.pglVertexArrayBindVertexBufferEXT != null, "pglVertexArrayBindVertexBufferEXT not implemented");
			Delegates.pglVertexArrayBindVertexBufferEXT(vaobj, bindingindex, buffer, offset, stride);
			LogFunction("glVertexArrayBindVertexBufferEXT({0}, {1}, {2}, 0x{3}, {4})", vaobj, bindingindex, buffer, offset.ToString("X8"), stride);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexArrayVertexAttribFormatEXT.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="attribindex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="normalized">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="relativeoffset">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void VertexArrayVertexAttribFormatEXT(UInt32 vaobj, UInt32 attribindex, Int32 size, Int32 type, bool normalized, UInt32 relativeoffset)
		{
			Debug.Assert(Delegates.pglVertexArrayVertexAttribFormatEXT != null, "pglVertexArrayVertexAttribFormatEXT not implemented");
			Delegates.pglVertexArrayVertexAttribFormatEXT(vaobj, attribindex, size, type, normalized, relativeoffset);
			LogFunction("glVertexArrayVertexAttribFormatEXT({0}, {1}, {2}, {3}, {4}, {5})", vaobj, attribindex, size, LogEnumName(type), normalized, relativeoffset);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexArrayVertexAttribIFormatEXT.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="attribindex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="relativeoffset">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void VertexArrayVertexAttribIFormatEXT(UInt32 vaobj, UInt32 attribindex, Int32 size, Int32 type, UInt32 relativeoffset)
		{
			Debug.Assert(Delegates.pglVertexArrayVertexAttribIFormatEXT != null, "pglVertexArrayVertexAttribIFormatEXT not implemented");
			Delegates.pglVertexArrayVertexAttribIFormatEXT(vaobj, attribindex, size, type, relativeoffset);
			LogFunction("glVertexArrayVertexAttribIFormatEXT({0}, {1}, {2}, {3}, {4})", vaobj, attribindex, size, LogEnumName(type), relativeoffset);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexArrayVertexAttribLFormatEXT.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="attribindex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="relativeoffset">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void VertexArrayVertexAttribLFormatEXT(UInt32 vaobj, UInt32 attribindex, Int32 size, Int32 type, UInt32 relativeoffset)
		{
			Debug.Assert(Delegates.pglVertexArrayVertexAttribLFormatEXT != null, "pglVertexArrayVertexAttribLFormatEXT not implemented");
			Delegates.pglVertexArrayVertexAttribLFormatEXT(vaobj, attribindex, size, type, relativeoffset);
			LogFunction("glVertexArrayVertexAttribLFormatEXT({0}, {1}, {2}, {3}, {4})", vaobj, attribindex, size, LogEnumName(type), relativeoffset);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexArrayVertexAttribBindingEXT.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="attribindex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="bindingindex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void VertexArrayVertexAttribBindingEXT(UInt32 vaobj, UInt32 attribindex, UInt32 bindingindex)
		{
			Debug.Assert(Delegates.pglVertexArrayVertexAttribBindingEXT != null, "pglVertexArrayVertexAttribBindingEXT not implemented");
			Delegates.pglVertexArrayVertexAttribBindingEXT(vaobj, attribindex, bindingindex);
			LogFunction("glVertexArrayVertexAttribBindingEXT({0}, {1}, {2})", vaobj, attribindex, bindingindex);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexArrayVertexBindingDivisorEXT.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="bindingindex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="divisor">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void VertexArrayVertexBindingDivisorEXT(UInt32 vaobj, UInt32 bindingindex, UInt32 divisor)
		{
			Debug.Assert(Delegates.pglVertexArrayVertexBindingDivisorEXT != null, "pglVertexArrayVertexBindingDivisorEXT not implemented");
			Delegates.pglVertexArrayVertexBindingDivisorEXT(vaobj, bindingindex, divisor);
			LogFunction("glVertexArrayVertexBindingDivisorEXT({0}, {1}, {2})", vaobj, bindingindex, divisor);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexArrayVertexAttribLOffsetEXT.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void VertexArrayVertexAttribLOffsetEXT(UInt32 vaobj, UInt32 buffer, UInt32 index, Int32 size, Int32 type, Int32 stride, IntPtr offset)
		{
			Debug.Assert(Delegates.pglVertexArrayVertexAttribLOffsetEXT != null, "pglVertexArrayVertexAttribLOffsetEXT not implemented");
			Delegates.pglVertexArrayVertexAttribLOffsetEXT(vaobj, buffer, index, size, type, stride, offset);
			LogFunction("glVertexArrayVertexAttribLOffsetEXT({0}, {1}, {2}, {3}, {4}, {5}, 0x{6})", vaobj, buffer, index, size, LogEnumName(type), stride, offset.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexturePageCommitmentEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="commit">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void TexturePageCommitmentEXT(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, bool commit)
		{
			Debug.Assert(Delegates.pglTexturePageCommitmentEXT != null, "pglTexturePageCommitmentEXT not implemented");
			Delegates.pglTexturePageCommitmentEXT(texture, level, xoffset, yoffset, zoffset, width, height, depth, commit);
			LogFunction("glTexturePageCommitmentEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", texture, level, xoffset, yoffset, zoffset, width, height, depth, commit);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexArrayVertexAttribDivisorEXT.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="divisor">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void VertexArrayVertexAttribDivisorEXT(UInt32 vaobj, UInt32 index, UInt32 divisor)
		{
			Debug.Assert(Delegates.pglVertexArrayVertexAttribDivisorEXT != null, "pglVertexArrayVertexAttribDivisorEXT not implemented");
			Delegates.pglVertexArrayVertexAttribDivisorEXT(vaobj, index, divisor);
			LogFunction("glVertexArrayVertexAttribDivisorEXT({0}, {1}, {2})", vaobj, index, divisor);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMatrixLoadfEXT", ExactSpelling = true)]
			internal extern static unsafe void glMatrixLoadfEXT(Int32 mode, float* m);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMatrixLoaddEXT", ExactSpelling = true)]
			internal extern static unsafe void glMatrixLoaddEXT(Int32 mode, double* m);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMatrixMultfEXT", ExactSpelling = true)]
			internal extern static unsafe void glMatrixMultfEXT(Int32 mode, float* m);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMatrixMultdEXT", ExactSpelling = true)]
			internal extern static unsafe void glMatrixMultdEXT(Int32 mode, double* m);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMatrixLoadIdentityEXT", ExactSpelling = true)]
			internal extern static void glMatrixLoadIdentityEXT(Int32 mode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMatrixRotatefEXT", ExactSpelling = true)]
			internal extern static void glMatrixRotatefEXT(Int32 mode, float angle, float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMatrixRotatedEXT", ExactSpelling = true)]
			internal extern static void glMatrixRotatedEXT(Int32 mode, double angle, double x, double y, double z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMatrixScalefEXT", ExactSpelling = true)]
			internal extern static void glMatrixScalefEXT(Int32 mode, float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMatrixScaledEXT", ExactSpelling = true)]
			internal extern static void glMatrixScaledEXT(Int32 mode, double x, double y, double z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMatrixTranslatefEXT", ExactSpelling = true)]
			internal extern static void glMatrixTranslatefEXT(Int32 mode, float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMatrixTranslatedEXT", ExactSpelling = true)]
			internal extern static void glMatrixTranslatedEXT(Int32 mode, double x, double y, double z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMatrixFrustumEXT", ExactSpelling = true)]
			internal extern static void glMatrixFrustumEXT(Int32 mode, double left, double right, double bottom, double top, double zNear, double zFar);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMatrixOrthoEXT", ExactSpelling = true)]
			internal extern static void glMatrixOrthoEXT(Int32 mode, double left, double right, double bottom, double top, double zNear, double zFar);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMatrixPopEXT", ExactSpelling = true)]
			internal extern static void glMatrixPopEXT(Int32 mode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMatrixPushEXT", ExactSpelling = true)]
			internal extern static void glMatrixPushEXT(Int32 mode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClientAttribDefaultEXT", ExactSpelling = true)]
			internal extern static void glClientAttribDefaultEXT(UInt32 mask);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPushClientAttribDefaultEXT", ExactSpelling = true)]
			internal extern static void glPushClientAttribDefaultEXT(UInt32 mask);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureParameterfEXT", ExactSpelling = true)]
			internal extern static void glTextureParameterfEXT(UInt32 texture, Int32 target, Int32 pname, float param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glTextureParameterfvEXT(UInt32 texture, Int32 target, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureParameteriEXT", ExactSpelling = true)]
			internal extern static void glTextureParameteriEXT(UInt32 texture, Int32 target, Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glTextureParameterivEXT(UInt32 texture, Int32 target, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureImage1DEXT", ExactSpelling = true)]
			internal extern static unsafe void glTextureImage1DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureImage2DEXT", ExactSpelling = true)]
			internal extern static unsafe void glTextureImage2DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureSubImage1DEXT", ExactSpelling = true)]
			internal extern static unsafe void glTextureSubImage1DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureSubImage2DEXT", ExactSpelling = true)]
			internal extern static unsafe void glTextureSubImage2DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCopyTextureImage1DEXT", ExactSpelling = true)]
			internal extern static void glCopyTextureImage1DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 border);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCopyTextureImage2DEXT", ExactSpelling = true)]
			internal extern static void glCopyTextureImage2DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCopyTextureSubImage1DEXT", ExactSpelling = true)]
			internal extern static void glCopyTextureSubImage1DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCopyTextureSubImage2DEXT", ExactSpelling = true)]
			internal extern static void glCopyTextureSubImage2DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTextureImageEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureImageEXT(UInt32 texture, Int32 target, Int32 level, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTextureParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureParameterfvEXT(UInt32 texture, Int32 target, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTextureParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureParameterivEXT(UInt32 texture, Int32 target, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTextureLevelParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureLevelParameterfvEXT(UInt32 texture, Int32 target, Int32 level, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTextureLevelParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureLevelParameterivEXT(UInt32 texture, Int32 target, Int32 level, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureImage3DEXT", ExactSpelling = true)]
			internal extern static unsafe void glTextureImage3DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureSubImage3DEXT", ExactSpelling = true)]
			internal extern static unsafe void glTextureSubImage3DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCopyTextureSubImage3DEXT", ExactSpelling = true)]
			internal extern static void glCopyTextureSubImage3DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBindMultiTextureEXT", ExactSpelling = true)]
			internal extern static void glBindMultiTextureEXT(Int32 texunit, Int32 target, UInt32 texture);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexCoordPointerEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoordPointerEXT(Int32 texunit, Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexEnvfEXT", ExactSpelling = true)]
			internal extern static void glMultiTexEnvfEXT(Int32 texunit, Int32 target, Int32 pname, float param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexEnvfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexEnvfvEXT(Int32 texunit, Int32 target, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexEnviEXT", ExactSpelling = true)]
			internal extern static void glMultiTexEnviEXT(Int32 texunit, Int32 target, Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexEnvivEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexEnvivEXT(Int32 texunit, Int32 target, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexGendEXT", ExactSpelling = true)]
			internal extern static void glMultiTexGendEXT(Int32 texunit, Int32 coord, Int32 pname, double param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexGendvEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexGendvEXT(Int32 texunit, Int32 coord, Int32 pname, double* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexGenfEXT", ExactSpelling = true)]
			internal extern static void glMultiTexGenfEXT(Int32 texunit, Int32 coord, Int32 pname, float param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexGenfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexGenfvEXT(Int32 texunit, Int32 coord, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexGeniEXT", ExactSpelling = true)]
			internal extern static void glMultiTexGeniEXT(Int32 texunit, Int32 coord, Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexGenivEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexGenivEXT(Int32 texunit, Int32 coord, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetMultiTexEnvfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMultiTexEnvfvEXT(Int32 texunit, Int32 target, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetMultiTexEnvivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMultiTexEnvivEXT(Int32 texunit, Int32 target, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetMultiTexGendvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMultiTexGendvEXT(Int32 texunit, Int32 coord, Int32 pname, double* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetMultiTexGenfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMultiTexGenfvEXT(Int32 texunit, Int32 coord, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetMultiTexGenivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMultiTexGenivEXT(Int32 texunit, Int32 coord, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexParameteriEXT", ExactSpelling = true)]
			internal extern static void glMultiTexParameteriEXT(Int32 texunit, Int32 target, Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexParameterivEXT(Int32 texunit, Int32 target, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexParameterfEXT", ExactSpelling = true)]
			internal extern static void glMultiTexParameterfEXT(Int32 texunit, Int32 target, Int32 pname, float param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexParameterfvEXT(Int32 texunit, Int32 target, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexImage1DEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexImage1DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexImage2DEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexImage2DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexSubImage1DEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexSubImage1DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexSubImage2DEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexSubImage2DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCopyMultiTexImage1DEXT", ExactSpelling = true)]
			internal extern static void glCopyMultiTexImage1DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 border);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCopyMultiTexImage2DEXT", ExactSpelling = true)]
			internal extern static void glCopyMultiTexImage2DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCopyMultiTexSubImage1DEXT", ExactSpelling = true)]
			internal extern static void glCopyMultiTexSubImage1DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCopyMultiTexSubImage2DEXT", ExactSpelling = true)]
			internal extern static void glCopyMultiTexSubImage2DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetMultiTexImageEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMultiTexImageEXT(Int32 texunit, Int32 target, Int32 level, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetMultiTexParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMultiTexParameterfvEXT(Int32 texunit, Int32 target, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetMultiTexParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMultiTexParameterivEXT(Int32 texunit, Int32 target, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetMultiTexLevelParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMultiTexLevelParameterfvEXT(Int32 texunit, Int32 target, Int32 level, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetMultiTexLevelParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMultiTexLevelParameterivEXT(Int32 texunit, Int32 target, Int32 level, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexImage3DEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexImage3DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexSubImage3DEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexSubImage3DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCopyMultiTexSubImage3DEXT", ExactSpelling = true)]
			internal extern static void glCopyMultiTexSubImage3DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEnableClientStateIndexedEXT", ExactSpelling = true)]
			internal extern static void glEnableClientStateIndexedEXT(Int32 array, UInt32 index);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDisableClientStateIndexedEXT", ExactSpelling = true)]
			internal extern static void glDisableClientStateIndexedEXT(Int32 array, UInt32 index);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetPointerIndexedvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetPointerIndexedvEXT(Int32 target, UInt32 index, IntPtr* data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCompressedTextureImage3DEXT", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTextureImage3DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr bits);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCompressedTextureImage2DEXT", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTextureImage2DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr bits);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCompressedTextureImage1DEXT", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTextureImage1DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr bits);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCompressedTextureSubImage3DEXT", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTextureSubImage3DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 imageSize, IntPtr bits);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCompressedTextureSubImage2DEXT", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTextureSubImage2DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 imageSize, IntPtr bits);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCompressedTextureSubImage1DEXT", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTextureSubImage1DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 imageSize, IntPtr bits);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetCompressedTextureImageEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetCompressedTextureImageEXT(UInt32 texture, Int32 target, Int32 lod, IntPtr img);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCompressedMultiTexImage3DEXT", ExactSpelling = true)]
			internal extern static unsafe void glCompressedMultiTexImage3DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr bits);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCompressedMultiTexImage2DEXT", ExactSpelling = true)]
			internal extern static unsafe void glCompressedMultiTexImage2DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr bits);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCompressedMultiTexImage1DEXT", ExactSpelling = true)]
			internal extern static unsafe void glCompressedMultiTexImage1DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr bits);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCompressedMultiTexSubImage3DEXT", ExactSpelling = true)]
			internal extern static unsafe void glCompressedMultiTexSubImage3DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 imageSize, IntPtr bits);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCompressedMultiTexSubImage2DEXT", ExactSpelling = true)]
			internal extern static unsafe void glCompressedMultiTexSubImage2DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 imageSize, IntPtr bits);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCompressedMultiTexSubImage1DEXT", ExactSpelling = true)]
			internal extern static unsafe void glCompressedMultiTexSubImage1DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 imageSize, IntPtr bits);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetCompressedMultiTexImageEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetCompressedMultiTexImageEXT(Int32 texunit, Int32 target, Int32 lod, IntPtr img);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMatrixLoadTransposefEXT", ExactSpelling = true)]
			internal extern static unsafe void glMatrixLoadTransposefEXT(Int32 mode, float* m);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMatrixLoadTransposedEXT", ExactSpelling = true)]
			internal extern static unsafe void glMatrixLoadTransposedEXT(Int32 mode, double* m);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMatrixMultTransposefEXT", ExactSpelling = true)]
			internal extern static unsafe void glMatrixMultTransposefEXT(Int32 mode, float* m);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMatrixMultTransposedEXT", ExactSpelling = true)]
			internal extern static unsafe void glMatrixMultTransposedEXT(Int32 mode, double* m);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedBufferDataEXT", ExactSpelling = true)]
			internal extern static unsafe void glNamedBufferDataEXT(UInt32 buffer, UInt32 size, IntPtr data, Int32 usage);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMapNamedBufferEXT", ExactSpelling = true)]
			internal extern static IntPtr glMapNamedBufferEXT(UInt32 buffer, Int32 access);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUnmapNamedBufferEXT", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glUnmapNamedBufferEXT(UInt32 buffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetNamedBufferParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedBufferParameterivEXT(UInt32 buffer, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetNamedBufferPointervEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedBufferPointervEXT(UInt32 buffer, Int32 pname, IntPtr* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetNamedBufferSubDataEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedBufferSubDataEXT(UInt32 buffer, IntPtr offset, UInt32 size, IntPtr data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureBufferEXT", ExactSpelling = true)]
			internal extern static void glTextureBufferEXT(UInt32 texture, Int32 target, Int32 internalformat, UInt32 buffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexBufferEXT", ExactSpelling = true)]
			internal extern static void glMultiTexBufferEXT(Int32 texunit, Int32 target, Int32 internalformat, UInt32 buffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureParameterIivEXT", ExactSpelling = true)]
			internal extern static unsafe void glTextureParameterIivEXT(UInt32 texture, Int32 target, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureParameterIuivEXT", ExactSpelling = true)]
			internal extern static unsafe void glTextureParameterIuivEXT(UInt32 texture, Int32 target, Int32 pname, UInt32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTextureParameterIivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureParameterIivEXT(UInt32 texture, Int32 target, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTextureParameterIuivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureParameterIuivEXT(UInt32 texture, Int32 target, Int32 pname, UInt32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexParameterIivEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexParameterIivEXT(Int32 texunit, Int32 target, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexParameterIuivEXT", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexParameterIuivEXT(Int32 texunit, Int32 target, Int32 pname, UInt32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetMultiTexParameterIivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMultiTexParameterIivEXT(Int32 texunit, Int32 target, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetMultiTexParameterIuivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetMultiTexParameterIuivEXT(Int32 texunit, Int32 target, Int32 pname, UInt32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedProgramLocalParameters4fvEXT", ExactSpelling = true)]
			internal extern static unsafe void glNamedProgramLocalParameters4fvEXT(UInt32 program, Int32 target, UInt32 index, Int32 count, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedProgramLocalParameterI4iEXT", ExactSpelling = true)]
			internal extern static void glNamedProgramLocalParameterI4iEXT(UInt32 program, Int32 target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedProgramLocalParameterI4ivEXT", ExactSpelling = true)]
			internal extern static unsafe void glNamedProgramLocalParameterI4ivEXT(UInt32 program, Int32 target, UInt32 index, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedProgramLocalParametersI4ivEXT", ExactSpelling = true)]
			internal extern static unsafe void glNamedProgramLocalParametersI4ivEXT(UInt32 program, Int32 target, UInt32 index, Int32 count, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedProgramLocalParameterI4uiEXT", ExactSpelling = true)]
			internal extern static void glNamedProgramLocalParameterI4uiEXT(UInt32 program, Int32 target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedProgramLocalParameterI4uivEXT", ExactSpelling = true)]
			internal extern static unsafe void glNamedProgramLocalParameterI4uivEXT(UInt32 program, Int32 target, UInt32 index, UInt32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedProgramLocalParametersI4uivEXT", ExactSpelling = true)]
			internal extern static unsafe void glNamedProgramLocalParametersI4uivEXT(UInt32 program, Int32 target, UInt32 index, Int32 count, UInt32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetNamedProgramLocalParameterIivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedProgramLocalParameterIivEXT(UInt32 program, Int32 target, UInt32 index, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetNamedProgramLocalParameterIuivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedProgramLocalParameterIuivEXT(UInt32 program, Int32 target, UInt32 index, UInt32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEnableClientStateiEXT", ExactSpelling = true)]
			internal extern static void glEnableClientStateiEXT(Int32 array, UInt32 index);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDisableClientStateiEXT", ExactSpelling = true)]
			internal extern static void glDisableClientStateiEXT(Int32 array, UInt32 index);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetPointeri_vEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetPointeri_vEXT(Int32 pname, UInt32 index, IntPtr* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedProgramStringEXT", ExactSpelling = true)]
			internal extern static unsafe void glNamedProgramStringEXT(UInt32 program, Int32 target, Int32 format, Int32 len, IntPtr @string);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedProgramLocalParameter4dEXT", ExactSpelling = true)]
			internal extern static void glNamedProgramLocalParameter4dEXT(UInt32 program, Int32 target, UInt32 index, double x, double y, double z, double w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedProgramLocalParameter4dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glNamedProgramLocalParameter4dvEXT(UInt32 program, Int32 target, UInt32 index, double* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedProgramLocalParameter4fEXT", ExactSpelling = true)]
			internal extern static void glNamedProgramLocalParameter4fEXT(UInt32 program, Int32 target, UInt32 index, float x, float y, float z, float w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedProgramLocalParameter4fvEXT", ExactSpelling = true)]
			internal extern static unsafe void glNamedProgramLocalParameter4fvEXT(UInt32 program, Int32 target, UInt32 index, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetNamedProgramLocalParameterdvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedProgramLocalParameterdvEXT(UInt32 program, Int32 target, UInt32 index, double* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetNamedProgramLocalParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedProgramLocalParameterfvEXT(UInt32 program, Int32 target, UInt32 index, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetNamedProgramivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedProgramivEXT(UInt32 program, Int32 target, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetNamedProgramStringEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedProgramStringEXT(UInt32 program, Int32 target, Int32 pname, IntPtr @string);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedRenderbufferStorageEXT", ExactSpelling = true)]
			internal extern static void glNamedRenderbufferStorageEXT(UInt32 renderbuffer, Int32 internalformat, Int32 width, Int32 height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetNamedRenderbufferParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedRenderbufferParameterivEXT(UInt32 renderbuffer, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedRenderbufferStorageMultisampleEXT", ExactSpelling = true)]
			internal extern static void glNamedRenderbufferStorageMultisampleEXT(UInt32 renderbuffer, Int32 samples, Int32 internalformat, Int32 width, Int32 height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedRenderbufferStorageMultisampleCoverageEXT", ExactSpelling = true)]
			internal extern static void glNamedRenderbufferStorageMultisampleCoverageEXT(UInt32 renderbuffer, Int32 coverageSamples, Int32 colorSamples, Int32 internalformat, Int32 width, Int32 height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCheckNamedFramebufferStatusEXT", ExactSpelling = true)]
			internal extern static Int32 glCheckNamedFramebufferStatusEXT(UInt32 framebuffer, Int32 target);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedFramebufferTexture1DEXT", ExactSpelling = true)]
			internal extern static void glNamedFramebufferTexture1DEXT(UInt32 framebuffer, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedFramebufferTexture2DEXT", ExactSpelling = true)]
			internal extern static void glNamedFramebufferTexture2DEXT(UInt32 framebuffer, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedFramebufferTexture3DEXT", ExactSpelling = true)]
			internal extern static void glNamedFramebufferTexture3DEXT(UInt32 framebuffer, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level, Int32 zoffset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedFramebufferRenderbufferEXT", ExactSpelling = true)]
			internal extern static void glNamedFramebufferRenderbufferEXT(UInt32 framebuffer, Int32 attachment, Int32 renderbuffertarget, UInt32 renderbuffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetNamedFramebufferAttachmentParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedFramebufferAttachmentParameterivEXT(UInt32 framebuffer, Int32 attachment, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGenerateTextureMipmapEXT", ExactSpelling = true)]
			internal extern static void glGenerateTextureMipmapEXT(UInt32 texture, Int32 target);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGenerateMultiTexMipmapEXT", ExactSpelling = true)]
			internal extern static void glGenerateMultiTexMipmapEXT(Int32 texunit, Int32 target);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFramebufferDrawBufferEXT", ExactSpelling = true)]
			internal extern static void glFramebufferDrawBufferEXT(UInt32 framebuffer, Int32 mode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFramebufferDrawBuffersEXT", ExactSpelling = true)]
			internal extern static unsafe void glFramebufferDrawBuffersEXT(UInt32 framebuffer, Int32 n, Int32* bufs);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFramebufferReadBufferEXT", ExactSpelling = true)]
			internal extern static void glFramebufferReadBufferEXT(UInt32 framebuffer, Int32 mode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetFramebufferParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetFramebufferParameterivEXT(UInt32 framebuffer, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedCopyBufferSubDataEXT", ExactSpelling = true)]
			internal extern static unsafe void glNamedCopyBufferSubDataEXT(UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, UInt32 size);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedFramebufferTextureEXT", ExactSpelling = true)]
			internal extern static void glNamedFramebufferTextureEXT(UInt32 framebuffer, Int32 attachment, UInt32 texture, Int32 level);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedFramebufferTextureLayerEXT", ExactSpelling = true)]
			internal extern static void glNamedFramebufferTextureLayerEXT(UInt32 framebuffer, Int32 attachment, UInt32 texture, Int32 level, Int32 layer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedFramebufferTextureFaceEXT", ExactSpelling = true)]
			internal extern static void glNamedFramebufferTextureFaceEXT(UInt32 framebuffer, Int32 attachment, UInt32 texture, Int32 level, Int32 face);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureRenderbufferEXT", ExactSpelling = true)]
			internal extern static void glTextureRenderbufferEXT(UInt32 texture, Int32 target, UInt32 renderbuffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexRenderbufferEXT", ExactSpelling = true)]
			internal extern static void glMultiTexRenderbufferEXT(Int32 texunit, Int32 target, UInt32 renderbuffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexArrayVertexOffsetEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayVertexOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 size, Int32 type, Int32 stride, IntPtr offset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexArrayColorOffsetEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayColorOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 size, Int32 type, Int32 stride, IntPtr offset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexArrayEdgeFlagOffsetEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayEdgeFlagOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 stride, IntPtr offset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexArrayIndexOffsetEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayIndexOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 type, Int32 stride, IntPtr offset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexArrayNormalOffsetEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayNormalOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 type, Int32 stride, IntPtr offset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexArrayTexCoordOffsetEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayTexCoordOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 size, Int32 type, Int32 stride, IntPtr offset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexArrayMultiTexCoordOffsetEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayMultiTexCoordOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 texunit, Int32 size, Int32 type, Int32 stride, IntPtr offset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexArrayFogCoordOffsetEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayFogCoordOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 type, Int32 stride, IntPtr offset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexArraySecondaryColorOffsetEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexArraySecondaryColorOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 size, Int32 type, Int32 stride, IntPtr offset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexArrayVertexAttribOffsetEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayVertexAttribOffsetEXT(UInt32 vaobj, UInt32 buffer, UInt32 index, Int32 size, Int32 type, bool normalized, Int32 stride, IntPtr offset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexArrayVertexAttribIOffsetEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayVertexAttribIOffsetEXT(UInt32 vaobj, UInt32 buffer, UInt32 index, Int32 size, Int32 type, Int32 stride, IntPtr offset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEnableVertexArrayEXT", ExactSpelling = true)]
			internal extern static void glEnableVertexArrayEXT(UInt32 vaobj, Int32 array);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDisableVertexArrayEXT", ExactSpelling = true)]
			internal extern static void glDisableVertexArrayEXT(UInt32 vaobj, Int32 array);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEnableVertexArrayAttribEXT", ExactSpelling = true)]
			internal extern static void glEnableVertexArrayAttribEXT(UInt32 vaobj, UInt32 index);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDisableVertexArrayAttribEXT", ExactSpelling = true)]
			internal extern static void glDisableVertexArrayAttribEXT(UInt32 vaobj, UInt32 index);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetVertexArrayIntegervEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexArrayIntegervEXT(UInt32 vaobj, Int32 pname, Int32* param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetVertexArrayPointervEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexArrayPointervEXT(UInt32 vaobj, Int32 pname, IntPtr* param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetVertexArrayIntegeri_vEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexArrayIntegeri_vEXT(UInt32 vaobj, UInt32 index, Int32 pname, Int32* param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetVertexArrayPointeri_vEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexArrayPointeri_vEXT(UInt32 vaobj, UInt32 index, Int32 pname, IntPtr* param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMapNamedBufferRangeEXT", ExactSpelling = true)]
			internal extern static unsafe IntPtr glMapNamedBufferRangeEXT(UInt32 buffer, IntPtr offset, UInt32 length, UInt32 access);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFlushMappedNamedBufferRangeEXT", ExactSpelling = true)]
			internal extern static unsafe void glFlushMappedNamedBufferRangeEXT(UInt32 buffer, IntPtr offset, UInt32 length);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClearNamedBufferDataEXT", ExactSpelling = true)]
			internal extern static unsafe void glClearNamedBufferDataEXT(UInt32 buffer, Int32 internalformat, Int32 format, Int32 type, IntPtr data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClearNamedBufferSubDataEXT", ExactSpelling = true)]
			internal extern static unsafe void glClearNamedBufferSubDataEXT(UInt32 buffer, Int32 internalformat, UInt32 offset, UInt32 size, Int32 format, Int32 type, IntPtr data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedFramebufferParameteriEXT", ExactSpelling = true)]
			internal extern static void glNamedFramebufferParameteriEXT(UInt32 framebuffer, Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetNamedFramebufferParameterivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedFramebufferParameterivEXT(UInt32 framebuffer, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform1dEXT", ExactSpelling = true)]
			internal extern static void glProgramUniform1dEXT(UInt32 program, Int32 location, double x);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform2dEXT", ExactSpelling = true)]
			internal extern static void glProgramUniform2dEXT(UInt32 program, Int32 location, double x, double y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform3dEXT", ExactSpelling = true)]
			internal extern static void glProgramUniform3dEXT(UInt32 program, Int32 location, double x, double y, double z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform4dEXT", ExactSpelling = true)]
			internal extern static void glProgramUniform4dEXT(UInt32 program, Int32 location, double x, double y, double z, double w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform1dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform1dvEXT(UInt32 program, Int32 location, Int32 count, double* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform2dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform2dvEXT(UInt32 program, Int32 location, Int32 count, double* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform3dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform3dvEXT(UInt32 program, Int32 location, Int32 count, double* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform4dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform4dvEXT(UInt32 program, Int32 location, Int32 count, double* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformMatrix2dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix2dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformMatrix3dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix3dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformMatrix4dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix4dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformMatrix2x3dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix2x3dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformMatrix2x4dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix2x4dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformMatrix3x2dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix3x2dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformMatrix3x4dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix3x4dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformMatrix4x2dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix4x2dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformMatrix4x3dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformMatrix4x3dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureBufferRangeEXT", ExactSpelling = true)]
			internal extern static unsafe void glTextureBufferRangeEXT(UInt32 texture, Int32 target, Int32 internalformat, UInt32 buffer, IntPtr offset, UInt32 size);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureStorage1DEXT", ExactSpelling = true)]
			internal extern static void glTextureStorage1DEXT(UInt32 texture, Int32 target, Int32 levels, Int32 internalformat, Int32 width);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureStorage2DEXT", ExactSpelling = true)]
			internal extern static void glTextureStorage2DEXT(UInt32 texture, Int32 target, Int32 levels, Int32 internalformat, Int32 width, Int32 height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureStorage3DEXT", ExactSpelling = true)]
			internal extern static void glTextureStorage3DEXT(UInt32 texture, Int32 target, Int32 levels, Int32 internalformat, Int32 width, Int32 height, Int32 depth);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureStorage2DMultisampleEXT", ExactSpelling = true)]
			internal extern static void glTextureStorage2DMultisampleEXT(UInt32 texture, Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height, bool fixedsamplelocations);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureStorage3DMultisampleEXT", ExactSpelling = true)]
			internal extern static void glTextureStorage3DMultisampleEXT(UInt32 texture, Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexArrayBindVertexBufferEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayBindVertexBufferEXT(UInt32 vaobj, UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexArrayVertexAttribFormatEXT", ExactSpelling = true)]
			internal extern static void glVertexArrayVertexAttribFormatEXT(UInt32 vaobj, UInt32 attribindex, Int32 size, Int32 type, bool normalized, UInt32 relativeoffset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexArrayVertexAttribIFormatEXT", ExactSpelling = true)]
			internal extern static void glVertexArrayVertexAttribIFormatEXT(UInt32 vaobj, UInt32 attribindex, Int32 size, Int32 type, UInt32 relativeoffset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexArrayVertexAttribLFormatEXT", ExactSpelling = true)]
			internal extern static void glVertexArrayVertexAttribLFormatEXT(UInt32 vaobj, UInt32 attribindex, Int32 size, Int32 type, UInt32 relativeoffset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexArrayVertexAttribBindingEXT", ExactSpelling = true)]
			internal extern static void glVertexArrayVertexAttribBindingEXT(UInt32 vaobj, UInt32 attribindex, UInt32 bindingindex);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexArrayVertexBindingDivisorEXT", ExactSpelling = true)]
			internal extern static void glVertexArrayVertexBindingDivisorEXT(UInt32 vaobj, UInt32 bindingindex, UInt32 divisor);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexArrayVertexAttribLOffsetEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayVertexAttribLOffsetEXT(UInt32 vaobj, UInt32 buffer, UInt32 index, Int32 size, Int32 type, Int32 stride, IntPtr offset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexturePageCommitmentEXT", ExactSpelling = true)]
			internal extern static void glTexturePageCommitmentEXT(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, bool commit);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexArrayVertexAttribDivisorEXT", ExactSpelling = true)]
			internal extern static void glVertexArrayVertexAttribDivisorEXT(UInt32 vaobj, UInt32 index, UInt32 divisor);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixLoadfEXT(Int32 mode, float* m);

			[ThreadStatic]
			internal static glMatrixLoadfEXT pglMatrixLoadfEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixLoaddEXT(Int32 mode, double* m);

			[ThreadStatic]
			internal static glMatrixLoaddEXT pglMatrixLoaddEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixMultfEXT(Int32 mode, float* m);

			[ThreadStatic]
			internal static glMatrixMultfEXT pglMatrixMultfEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixMultdEXT(Int32 mode, double* m);

			[ThreadStatic]
			internal static glMatrixMultdEXT pglMatrixMultdEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMatrixLoadIdentityEXT(Int32 mode);

			[ThreadStatic]
			internal static glMatrixLoadIdentityEXT pglMatrixLoadIdentityEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMatrixRotatefEXT(Int32 mode, float angle, float x, float y, float z);

			[ThreadStatic]
			internal static glMatrixRotatefEXT pglMatrixRotatefEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMatrixRotatedEXT(Int32 mode, double angle, double x, double y, double z);

			[ThreadStatic]
			internal static glMatrixRotatedEXT pglMatrixRotatedEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMatrixScalefEXT(Int32 mode, float x, float y, float z);

			[ThreadStatic]
			internal static glMatrixScalefEXT pglMatrixScalefEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMatrixScaledEXT(Int32 mode, double x, double y, double z);

			[ThreadStatic]
			internal static glMatrixScaledEXT pglMatrixScaledEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMatrixTranslatefEXT(Int32 mode, float x, float y, float z);

			[ThreadStatic]
			internal static glMatrixTranslatefEXT pglMatrixTranslatefEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMatrixTranslatedEXT(Int32 mode, double x, double y, double z);

			[ThreadStatic]
			internal static glMatrixTranslatedEXT pglMatrixTranslatedEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMatrixFrustumEXT(Int32 mode, double left, double right, double bottom, double top, double zNear, double zFar);

			[ThreadStatic]
			internal static glMatrixFrustumEXT pglMatrixFrustumEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMatrixOrthoEXT(Int32 mode, double left, double right, double bottom, double top, double zNear, double zFar);

			[ThreadStatic]
			internal static glMatrixOrthoEXT pglMatrixOrthoEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMatrixPopEXT(Int32 mode);

			[ThreadStatic]
			internal static glMatrixPopEXT pglMatrixPopEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMatrixPushEXT(Int32 mode);

			[ThreadStatic]
			internal static glMatrixPushEXT pglMatrixPushEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClientAttribDefaultEXT(UInt32 mask);

			[ThreadStatic]
			internal static glClientAttribDefaultEXT pglClientAttribDefaultEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPushClientAttribDefaultEXT(UInt32 mask);

			[ThreadStatic]
			internal static glPushClientAttribDefaultEXT pglPushClientAttribDefaultEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureParameterfEXT(UInt32 texture, Int32 target, Int32 pname, float param);

			[ThreadStatic]
			internal static glTextureParameterfEXT pglTextureParameterfEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureParameterfvEXT(UInt32 texture, Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glTextureParameterfvEXT pglTextureParameterfvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureParameteriEXT(UInt32 texture, Int32 target, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glTextureParameteriEXT pglTextureParameteriEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureParameterivEXT(UInt32 texture, Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glTextureParameterivEXT pglTextureParameterivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureImage1DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glTextureImage1DEXT pglTextureImage1DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureImage2DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glTextureImage2DEXT pglTextureImage2DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureSubImage1DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glTextureSubImage1DEXT pglTextureSubImage1DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureSubImage2DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glTextureSubImage2DEXT pglTextureSubImage2DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTextureImage1DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 border);

			[ThreadStatic]
			internal static glCopyTextureImage1DEXT pglCopyTextureImage1DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTextureImage2DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);

			[ThreadStatic]
			internal static glCopyTextureImage2DEXT pglCopyTextureImage2DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTextureSubImage1DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);

			[ThreadStatic]
			internal static glCopyTextureSubImage1DEXT pglCopyTextureSubImage1DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTextureSubImage2DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glCopyTextureSubImage2DEXT pglCopyTextureSubImage2DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureImageEXT(UInt32 texture, Int32 target, Int32 level, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glGetTextureImageEXT pglGetTextureImageEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureParameterfvEXT(UInt32 texture, Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetTextureParameterfvEXT pglGetTextureParameterfvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureParameterivEXT(UInt32 texture, Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetTextureParameterivEXT pglGetTextureParameterivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureLevelParameterfvEXT(UInt32 texture, Int32 target, Int32 level, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetTextureLevelParameterfvEXT pglGetTextureLevelParameterfvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureLevelParameterivEXT(UInt32 texture, Int32 target, Int32 level, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetTextureLevelParameterivEXT pglGetTextureLevelParameterivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureImage3DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glTextureImage3DEXT pglTextureImage3DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureSubImage3DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glTextureSubImage3DEXT pglTextureSubImage3DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTextureSubImage3DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glCopyTextureSubImage3DEXT pglCopyTextureSubImage3DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindMultiTextureEXT(Int32 texunit, Int32 target, UInt32 texture);

			[ThreadStatic]
			internal static glBindMultiTextureEXT pglBindMultiTextureEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoordPointerEXT(Int32 texunit, Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glMultiTexCoordPointerEXT pglMultiTexCoordPointerEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexEnvfEXT(Int32 texunit, Int32 target, Int32 pname, float param);

			[ThreadStatic]
			internal static glMultiTexEnvfEXT pglMultiTexEnvfEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexEnvfvEXT(Int32 texunit, Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glMultiTexEnvfvEXT pglMultiTexEnvfvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexEnviEXT(Int32 texunit, Int32 target, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glMultiTexEnviEXT pglMultiTexEnviEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexEnvivEXT(Int32 texunit, Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glMultiTexEnvivEXT pglMultiTexEnvivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexGendEXT(Int32 texunit, Int32 coord, Int32 pname, double param);

			[ThreadStatic]
			internal static glMultiTexGendEXT pglMultiTexGendEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexGendvEXT(Int32 texunit, Int32 coord, Int32 pname, double* @params);

			[ThreadStatic]
			internal static glMultiTexGendvEXT pglMultiTexGendvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexGenfEXT(Int32 texunit, Int32 coord, Int32 pname, float param);

			[ThreadStatic]
			internal static glMultiTexGenfEXT pglMultiTexGenfEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexGenfvEXT(Int32 texunit, Int32 coord, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glMultiTexGenfvEXT pglMultiTexGenfvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexGeniEXT(Int32 texunit, Int32 coord, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glMultiTexGeniEXT pglMultiTexGeniEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexGenivEXT(Int32 texunit, Int32 coord, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glMultiTexGenivEXT pglMultiTexGenivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMultiTexEnvfvEXT(Int32 texunit, Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetMultiTexEnvfvEXT pglGetMultiTexEnvfvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMultiTexEnvivEXT(Int32 texunit, Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetMultiTexEnvivEXT pglGetMultiTexEnvivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMultiTexGendvEXT(Int32 texunit, Int32 coord, Int32 pname, double* @params);

			[ThreadStatic]
			internal static glGetMultiTexGendvEXT pglGetMultiTexGendvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMultiTexGenfvEXT(Int32 texunit, Int32 coord, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetMultiTexGenfvEXT pglGetMultiTexGenfvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMultiTexGenivEXT(Int32 texunit, Int32 coord, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetMultiTexGenivEXT pglGetMultiTexGenivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexParameteriEXT(Int32 texunit, Int32 target, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glMultiTexParameteriEXT pglMultiTexParameteriEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexParameterivEXT(Int32 texunit, Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glMultiTexParameterivEXT pglMultiTexParameterivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexParameterfEXT(Int32 texunit, Int32 target, Int32 pname, float param);

			[ThreadStatic]
			internal static glMultiTexParameterfEXT pglMultiTexParameterfEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexParameterfvEXT(Int32 texunit, Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glMultiTexParameterfvEXT pglMultiTexParameterfvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexImage1DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glMultiTexImage1DEXT pglMultiTexImage1DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexImage2DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glMultiTexImage2DEXT pglMultiTexImage2DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexSubImage1DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glMultiTexSubImage1DEXT pglMultiTexSubImage1DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexSubImage2DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glMultiTexSubImage2DEXT pglMultiTexSubImage2DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyMultiTexImage1DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 border);

			[ThreadStatic]
			internal static glCopyMultiTexImage1DEXT pglCopyMultiTexImage1DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyMultiTexImage2DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);

			[ThreadStatic]
			internal static glCopyMultiTexImage2DEXT pglCopyMultiTexImage2DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyMultiTexSubImage1DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);

			[ThreadStatic]
			internal static glCopyMultiTexSubImage1DEXT pglCopyMultiTexSubImage1DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyMultiTexSubImage2DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glCopyMultiTexSubImage2DEXT pglCopyMultiTexSubImage2DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMultiTexImageEXT(Int32 texunit, Int32 target, Int32 level, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glGetMultiTexImageEXT pglGetMultiTexImageEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMultiTexParameterfvEXT(Int32 texunit, Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetMultiTexParameterfvEXT pglGetMultiTexParameterfvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMultiTexParameterivEXT(Int32 texunit, Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetMultiTexParameterivEXT pglGetMultiTexParameterivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMultiTexLevelParameterfvEXT(Int32 texunit, Int32 target, Int32 level, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetMultiTexLevelParameterfvEXT pglGetMultiTexLevelParameterfvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMultiTexLevelParameterivEXT(Int32 texunit, Int32 target, Int32 level, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetMultiTexLevelParameterivEXT pglGetMultiTexLevelParameterivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexImage3DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glMultiTexImage3DEXT pglMultiTexImage3DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexSubImage3DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glMultiTexSubImage3DEXT pglMultiTexSubImage3DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyMultiTexSubImage3DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glCopyMultiTexSubImage3DEXT pglCopyMultiTexSubImage3DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEnableClientStateIndexedEXT(Int32 array, UInt32 index);

			[ThreadStatic]
			internal static glEnableClientStateIndexedEXT pglEnableClientStateIndexedEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDisableClientStateIndexedEXT(Int32 array, UInt32 index);

			[ThreadStatic]
			internal static glDisableClientStateIndexedEXT pglDisableClientStateIndexedEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPointerIndexedvEXT(Int32 target, UInt32 index, IntPtr* data);

			[ThreadStatic]
			internal static glGetPointerIndexedvEXT pglGetPointerIndexedvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTextureImage3DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr bits);

			[ThreadStatic]
			internal static glCompressedTextureImage3DEXT pglCompressedTextureImage3DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTextureImage2DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr bits);

			[ThreadStatic]
			internal static glCompressedTextureImage2DEXT pglCompressedTextureImage2DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTextureImage1DEXT(UInt32 texture, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr bits);

			[ThreadStatic]
			internal static glCompressedTextureImage1DEXT pglCompressedTextureImage1DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTextureSubImage3DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 imageSize, IntPtr bits);

			[ThreadStatic]
			internal static glCompressedTextureSubImage3DEXT pglCompressedTextureSubImage3DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTextureSubImage2DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 imageSize, IntPtr bits);

			[ThreadStatic]
			internal static glCompressedTextureSubImage2DEXT pglCompressedTextureSubImage2DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTextureSubImage1DEXT(UInt32 texture, Int32 target, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 imageSize, IntPtr bits);

			[ThreadStatic]
			internal static glCompressedTextureSubImage1DEXT pglCompressedTextureSubImage1DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetCompressedTextureImageEXT(UInt32 texture, Int32 target, Int32 lod, IntPtr img);

			[ThreadStatic]
			internal static glGetCompressedTextureImageEXT pglGetCompressedTextureImageEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedMultiTexImage3DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr bits);

			[ThreadStatic]
			internal static glCompressedMultiTexImage3DEXT pglCompressedMultiTexImage3DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedMultiTexImage2DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr bits);

			[ThreadStatic]
			internal static glCompressedMultiTexImage2DEXT pglCompressedMultiTexImage2DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedMultiTexImage1DEXT(Int32 texunit, Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr bits);

			[ThreadStatic]
			internal static glCompressedMultiTexImage1DEXT pglCompressedMultiTexImage1DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedMultiTexSubImage3DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 imageSize, IntPtr bits);

			[ThreadStatic]
			internal static glCompressedMultiTexSubImage3DEXT pglCompressedMultiTexSubImage3DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedMultiTexSubImage2DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 imageSize, IntPtr bits);

			[ThreadStatic]
			internal static glCompressedMultiTexSubImage2DEXT pglCompressedMultiTexSubImage2DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedMultiTexSubImage1DEXT(Int32 texunit, Int32 target, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 imageSize, IntPtr bits);

			[ThreadStatic]
			internal static glCompressedMultiTexSubImage1DEXT pglCompressedMultiTexSubImage1DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetCompressedMultiTexImageEXT(Int32 texunit, Int32 target, Int32 lod, IntPtr img);

			[ThreadStatic]
			internal static glGetCompressedMultiTexImageEXT pglGetCompressedMultiTexImageEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixLoadTransposefEXT(Int32 mode, float* m);

			[ThreadStatic]
			internal static glMatrixLoadTransposefEXT pglMatrixLoadTransposefEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixLoadTransposedEXT(Int32 mode, double* m);

			[ThreadStatic]
			internal static glMatrixLoadTransposedEXT pglMatrixLoadTransposedEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixMultTransposefEXT(Int32 mode, float* m);

			[ThreadStatic]
			internal static glMatrixMultTransposefEXT pglMatrixMultTransposefEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixMultTransposedEXT(Int32 mode, double* m);

			[ThreadStatic]
			internal static glMatrixMultTransposedEXT pglMatrixMultTransposedEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedBufferDataEXT(UInt32 buffer, UInt32 size, IntPtr data, Int32 usage);

			[ThreadStatic]
			internal static glNamedBufferDataEXT pglNamedBufferDataEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr glMapNamedBufferEXT(UInt32 buffer, Int32 access);

			[ThreadStatic]
			internal static glMapNamedBufferEXT pglMapNamedBufferEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glUnmapNamedBufferEXT(UInt32 buffer);

			[ThreadStatic]
			internal static glUnmapNamedBufferEXT pglUnmapNamedBufferEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedBufferParameterivEXT(UInt32 buffer, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetNamedBufferParameterivEXT pglGetNamedBufferParameterivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedBufferPointervEXT(UInt32 buffer, Int32 pname, IntPtr* @params);

			[ThreadStatic]
			internal static glGetNamedBufferPointervEXT pglGetNamedBufferPointervEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedBufferSubDataEXT(UInt32 buffer, IntPtr offset, UInt32 size, IntPtr data);

			[ThreadStatic]
			internal static glGetNamedBufferSubDataEXT pglGetNamedBufferSubDataEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureBufferEXT(UInt32 texture, Int32 target, Int32 internalformat, UInt32 buffer);

			[ThreadStatic]
			internal static glTextureBufferEXT pglTextureBufferEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexBufferEXT(Int32 texunit, Int32 target, Int32 internalformat, UInt32 buffer);

			[ThreadStatic]
			internal static glMultiTexBufferEXT pglMultiTexBufferEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureParameterIivEXT(UInt32 texture, Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glTextureParameterIivEXT pglTextureParameterIivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureParameterIuivEXT(UInt32 texture, Int32 target, Int32 pname, UInt32* @params);

			[ThreadStatic]
			internal static glTextureParameterIuivEXT pglTextureParameterIuivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureParameterIivEXT(UInt32 texture, Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetTextureParameterIivEXT pglGetTextureParameterIivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureParameterIuivEXT(UInt32 texture, Int32 target, Int32 pname, UInt32* @params);

			[ThreadStatic]
			internal static glGetTextureParameterIuivEXT pglGetTextureParameterIuivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexParameterIivEXT(Int32 texunit, Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glMultiTexParameterIivEXT pglMultiTexParameterIivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexParameterIuivEXT(Int32 texunit, Int32 target, Int32 pname, UInt32* @params);

			[ThreadStatic]
			internal static glMultiTexParameterIuivEXT pglMultiTexParameterIuivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMultiTexParameterIivEXT(Int32 texunit, Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetMultiTexParameterIivEXT pglGetMultiTexParameterIivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMultiTexParameterIuivEXT(Int32 texunit, Int32 target, Int32 pname, UInt32* @params);

			[ThreadStatic]
			internal static glGetMultiTexParameterIuivEXT pglGetMultiTexParameterIuivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedProgramLocalParameters4fvEXT(UInt32 program, Int32 target, UInt32 index, Int32 count, float* @params);

			[ThreadStatic]
			internal static glNamedProgramLocalParameters4fvEXT pglNamedProgramLocalParameters4fvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedProgramLocalParameterI4iEXT(UInt32 program, Int32 target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);

			[ThreadStatic]
			internal static glNamedProgramLocalParameterI4iEXT pglNamedProgramLocalParameterI4iEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedProgramLocalParameterI4ivEXT(UInt32 program, Int32 target, UInt32 index, Int32* @params);

			[ThreadStatic]
			internal static glNamedProgramLocalParameterI4ivEXT pglNamedProgramLocalParameterI4ivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedProgramLocalParametersI4ivEXT(UInt32 program, Int32 target, UInt32 index, Int32 count, Int32* @params);

			[ThreadStatic]
			internal static glNamedProgramLocalParametersI4ivEXT pglNamedProgramLocalParametersI4ivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedProgramLocalParameterI4uiEXT(UInt32 program, Int32 target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);

			[ThreadStatic]
			internal static glNamedProgramLocalParameterI4uiEXT pglNamedProgramLocalParameterI4uiEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedProgramLocalParameterI4uivEXT(UInt32 program, Int32 target, UInt32 index, UInt32* @params);

			[ThreadStatic]
			internal static glNamedProgramLocalParameterI4uivEXT pglNamedProgramLocalParameterI4uivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedProgramLocalParametersI4uivEXT(UInt32 program, Int32 target, UInt32 index, Int32 count, UInt32* @params);

			[ThreadStatic]
			internal static glNamedProgramLocalParametersI4uivEXT pglNamedProgramLocalParametersI4uivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedProgramLocalParameterIivEXT(UInt32 program, Int32 target, UInt32 index, Int32* @params);

			[ThreadStatic]
			internal static glGetNamedProgramLocalParameterIivEXT pglGetNamedProgramLocalParameterIivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedProgramLocalParameterIuivEXT(UInt32 program, Int32 target, UInt32 index, UInt32* @params);

			[ThreadStatic]
			internal static glGetNamedProgramLocalParameterIuivEXT pglGetNamedProgramLocalParameterIuivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEnableClientStateiEXT(Int32 array, UInt32 index);

			[ThreadStatic]
			internal static glEnableClientStateiEXT pglEnableClientStateiEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDisableClientStateiEXT(Int32 array, UInt32 index);

			[ThreadStatic]
			internal static glDisableClientStateiEXT pglDisableClientStateiEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPointeri_vEXT(Int32 pname, UInt32 index, IntPtr* @params);

			[ThreadStatic]
			internal static glGetPointeri_vEXT pglGetPointeri_vEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedProgramStringEXT(UInt32 program, Int32 target, Int32 format, Int32 len, IntPtr @string);

			[ThreadStatic]
			internal static glNamedProgramStringEXT pglNamedProgramStringEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedProgramLocalParameter4dEXT(UInt32 program, Int32 target, UInt32 index, double x, double y, double z, double w);

			[ThreadStatic]
			internal static glNamedProgramLocalParameter4dEXT pglNamedProgramLocalParameter4dEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedProgramLocalParameter4dvEXT(UInt32 program, Int32 target, UInt32 index, double* @params);

			[ThreadStatic]
			internal static glNamedProgramLocalParameter4dvEXT pglNamedProgramLocalParameter4dvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedProgramLocalParameter4fEXT(UInt32 program, Int32 target, UInt32 index, float x, float y, float z, float w);

			[ThreadStatic]
			internal static glNamedProgramLocalParameter4fEXT pglNamedProgramLocalParameter4fEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedProgramLocalParameter4fvEXT(UInt32 program, Int32 target, UInt32 index, float* @params);

			[ThreadStatic]
			internal static glNamedProgramLocalParameter4fvEXT pglNamedProgramLocalParameter4fvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedProgramLocalParameterdvEXT(UInt32 program, Int32 target, UInt32 index, double* @params);

			[ThreadStatic]
			internal static glGetNamedProgramLocalParameterdvEXT pglGetNamedProgramLocalParameterdvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedProgramLocalParameterfvEXT(UInt32 program, Int32 target, UInt32 index, float* @params);

			[ThreadStatic]
			internal static glGetNamedProgramLocalParameterfvEXT pglGetNamedProgramLocalParameterfvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedProgramivEXT(UInt32 program, Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetNamedProgramivEXT pglGetNamedProgramivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedProgramStringEXT(UInt32 program, Int32 target, Int32 pname, IntPtr @string);

			[ThreadStatic]
			internal static glGetNamedProgramStringEXT pglGetNamedProgramStringEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedRenderbufferStorageEXT(UInt32 renderbuffer, Int32 internalformat, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glNamedRenderbufferStorageEXT pglNamedRenderbufferStorageEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedRenderbufferParameterivEXT(UInt32 renderbuffer, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetNamedRenderbufferParameterivEXT pglGetNamedRenderbufferParameterivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedRenderbufferStorageMultisampleEXT(UInt32 renderbuffer, Int32 samples, Int32 internalformat, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glNamedRenderbufferStorageMultisampleEXT pglNamedRenderbufferStorageMultisampleEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedRenderbufferStorageMultisampleCoverageEXT(UInt32 renderbuffer, Int32 coverageSamples, Int32 colorSamples, Int32 internalformat, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glNamedRenderbufferStorageMultisampleCoverageEXT pglNamedRenderbufferStorageMultisampleCoverageEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glCheckNamedFramebufferStatusEXT(UInt32 framebuffer, Int32 target);

			[ThreadStatic]
			internal static glCheckNamedFramebufferStatusEXT pglCheckNamedFramebufferStatusEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedFramebufferTexture1DEXT(UInt32 framebuffer, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level);

			[ThreadStatic]
			internal static glNamedFramebufferTexture1DEXT pglNamedFramebufferTexture1DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedFramebufferTexture2DEXT(UInt32 framebuffer, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level);

			[ThreadStatic]
			internal static glNamedFramebufferTexture2DEXT pglNamedFramebufferTexture2DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedFramebufferTexture3DEXT(UInt32 framebuffer, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level, Int32 zoffset);

			[ThreadStatic]
			internal static glNamedFramebufferTexture3DEXT pglNamedFramebufferTexture3DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedFramebufferRenderbufferEXT(UInt32 framebuffer, Int32 attachment, Int32 renderbuffertarget, UInt32 renderbuffer);

			[ThreadStatic]
			internal static glNamedFramebufferRenderbufferEXT pglNamedFramebufferRenderbufferEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedFramebufferAttachmentParameterivEXT(UInt32 framebuffer, Int32 attachment, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetNamedFramebufferAttachmentParameterivEXT pglGetNamedFramebufferAttachmentParameterivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glGenerateTextureMipmapEXT(UInt32 texture, Int32 target);

			[ThreadStatic]
			internal static glGenerateTextureMipmapEXT pglGenerateTextureMipmapEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glGenerateMultiTexMipmapEXT(Int32 texunit, Int32 target);

			[ThreadStatic]
			internal static glGenerateMultiTexMipmapEXT pglGenerateMultiTexMipmapEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferDrawBufferEXT(UInt32 framebuffer, Int32 mode);

			[ThreadStatic]
			internal static glFramebufferDrawBufferEXT pglFramebufferDrawBufferEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFramebufferDrawBuffersEXT(UInt32 framebuffer, Int32 n, Int32* bufs);

			[ThreadStatic]
			internal static glFramebufferDrawBuffersEXT pglFramebufferDrawBuffersEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferReadBufferEXT(UInt32 framebuffer, Int32 mode);

			[ThreadStatic]
			internal static glFramebufferReadBufferEXT pglFramebufferReadBufferEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFramebufferParameterivEXT(UInt32 framebuffer, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetFramebufferParameterivEXT pglGetFramebufferParameterivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedCopyBufferSubDataEXT(UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, UInt32 size);

			[ThreadStatic]
			internal static glNamedCopyBufferSubDataEXT pglNamedCopyBufferSubDataEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedFramebufferTextureEXT(UInt32 framebuffer, Int32 attachment, UInt32 texture, Int32 level);

			[ThreadStatic]
			internal static glNamedFramebufferTextureEXT pglNamedFramebufferTextureEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedFramebufferTextureLayerEXT(UInt32 framebuffer, Int32 attachment, UInt32 texture, Int32 level, Int32 layer);

			[ThreadStatic]
			internal static glNamedFramebufferTextureLayerEXT pglNamedFramebufferTextureLayerEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedFramebufferTextureFaceEXT(UInt32 framebuffer, Int32 attachment, UInt32 texture, Int32 level, Int32 face);

			[ThreadStatic]
			internal static glNamedFramebufferTextureFaceEXT pglNamedFramebufferTextureFaceEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureRenderbufferEXT(UInt32 texture, Int32 target, UInt32 renderbuffer);

			[ThreadStatic]
			internal static glTextureRenderbufferEXT pglTextureRenderbufferEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexRenderbufferEXT(Int32 texunit, Int32 target, UInt32 renderbuffer);

			[ThreadStatic]
			internal static glMultiTexRenderbufferEXT pglMultiTexRenderbufferEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayVertexOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 size, Int32 type, Int32 stride, IntPtr offset);

			[ThreadStatic]
			internal static glVertexArrayVertexOffsetEXT pglVertexArrayVertexOffsetEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayColorOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 size, Int32 type, Int32 stride, IntPtr offset);

			[ThreadStatic]
			internal static glVertexArrayColorOffsetEXT pglVertexArrayColorOffsetEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayEdgeFlagOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 stride, IntPtr offset);

			[ThreadStatic]
			internal static glVertexArrayEdgeFlagOffsetEXT pglVertexArrayEdgeFlagOffsetEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayIndexOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 type, Int32 stride, IntPtr offset);

			[ThreadStatic]
			internal static glVertexArrayIndexOffsetEXT pglVertexArrayIndexOffsetEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayNormalOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 type, Int32 stride, IntPtr offset);

			[ThreadStatic]
			internal static glVertexArrayNormalOffsetEXT pglVertexArrayNormalOffsetEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayTexCoordOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 size, Int32 type, Int32 stride, IntPtr offset);

			[ThreadStatic]
			internal static glVertexArrayTexCoordOffsetEXT pglVertexArrayTexCoordOffsetEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayMultiTexCoordOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 texunit, Int32 size, Int32 type, Int32 stride, IntPtr offset);

			[ThreadStatic]
			internal static glVertexArrayMultiTexCoordOffsetEXT pglVertexArrayMultiTexCoordOffsetEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayFogCoordOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 type, Int32 stride, IntPtr offset);

			[ThreadStatic]
			internal static glVertexArrayFogCoordOffsetEXT pglVertexArrayFogCoordOffsetEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArraySecondaryColorOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 size, Int32 type, Int32 stride, IntPtr offset);

			[ThreadStatic]
			internal static glVertexArraySecondaryColorOffsetEXT pglVertexArraySecondaryColorOffsetEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayVertexAttribOffsetEXT(UInt32 vaobj, UInt32 buffer, UInt32 index, Int32 size, Int32 type, bool normalized, Int32 stride, IntPtr offset);

			[ThreadStatic]
			internal static glVertexArrayVertexAttribOffsetEXT pglVertexArrayVertexAttribOffsetEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayVertexAttribIOffsetEXT(UInt32 vaobj, UInt32 buffer, UInt32 index, Int32 size, Int32 type, Int32 stride, IntPtr offset);

			[ThreadStatic]
			internal static glVertexArrayVertexAttribIOffsetEXT pglVertexArrayVertexAttribIOffsetEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEnableVertexArrayEXT(UInt32 vaobj, Int32 array);

			[ThreadStatic]
			internal static glEnableVertexArrayEXT pglEnableVertexArrayEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDisableVertexArrayEXT(UInt32 vaobj, Int32 array);

			[ThreadStatic]
			internal static glDisableVertexArrayEXT pglDisableVertexArrayEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEnableVertexArrayAttribEXT(UInt32 vaobj, UInt32 index);

			[ThreadStatic]
			internal static glEnableVertexArrayAttribEXT pglEnableVertexArrayAttribEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDisableVertexArrayAttribEXT(UInt32 vaobj, UInt32 index);

			[ThreadStatic]
			internal static glDisableVertexArrayAttribEXT pglDisableVertexArrayAttribEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexArrayIntegervEXT(UInt32 vaobj, Int32 pname, Int32* param);

			[ThreadStatic]
			internal static glGetVertexArrayIntegervEXT pglGetVertexArrayIntegervEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexArrayPointervEXT(UInt32 vaobj, Int32 pname, IntPtr* param);

			[ThreadStatic]
			internal static glGetVertexArrayPointervEXT pglGetVertexArrayPointervEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexArrayIntegeri_vEXT(UInt32 vaobj, UInt32 index, Int32 pname, Int32* param);

			[ThreadStatic]
			internal static glGetVertexArrayIntegeri_vEXT pglGetVertexArrayIntegeri_vEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexArrayPointeri_vEXT(UInt32 vaobj, UInt32 index, Int32 pname, IntPtr* param);

			[ThreadStatic]
			internal static glGetVertexArrayPointeri_vEXT pglGetVertexArrayPointeri_vEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glMapNamedBufferRangeEXT(UInt32 buffer, IntPtr offset, UInt32 length, UInt32 access);

			[ThreadStatic]
			internal static glMapNamedBufferRangeEXT pglMapNamedBufferRangeEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFlushMappedNamedBufferRangeEXT(UInt32 buffer, IntPtr offset, UInt32 length);

			[ThreadStatic]
			internal static glFlushMappedNamedBufferRangeEXT pglFlushMappedNamedBufferRangeEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearNamedBufferDataEXT(UInt32 buffer, Int32 internalformat, Int32 format, Int32 type, IntPtr data);

			[ThreadStatic]
			internal static glClearNamedBufferDataEXT pglClearNamedBufferDataEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearNamedBufferSubDataEXT(UInt32 buffer, Int32 internalformat, UInt32 offset, UInt32 size, Int32 format, Int32 type, IntPtr data);

			[ThreadStatic]
			internal static glClearNamedBufferSubDataEXT pglClearNamedBufferSubDataEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedFramebufferParameteriEXT(UInt32 framebuffer, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glNamedFramebufferParameteriEXT pglNamedFramebufferParameteriEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedFramebufferParameterivEXT(UInt32 framebuffer, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetNamedFramebufferParameterivEXT pglGetNamedFramebufferParameterivEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform1dEXT(UInt32 program, Int32 location, double x);

			[ThreadStatic]
			internal static glProgramUniform1dEXT pglProgramUniform1dEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform2dEXT(UInt32 program, Int32 location, double x, double y);

			[ThreadStatic]
			internal static glProgramUniform2dEXT pglProgramUniform2dEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform3dEXT(UInt32 program, Int32 location, double x, double y, double z);

			[ThreadStatic]
			internal static glProgramUniform3dEXT pglProgramUniform3dEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform4dEXT(UInt32 program, Int32 location, double x, double y, double z, double w);

			[ThreadStatic]
			internal static glProgramUniform4dEXT pglProgramUniform4dEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform1dvEXT(UInt32 program, Int32 location, Int32 count, double* value);

			[ThreadStatic]
			internal static glProgramUniform1dvEXT pglProgramUniform1dvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform2dvEXT(UInt32 program, Int32 location, Int32 count, double* value);

			[ThreadStatic]
			internal static glProgramUniform2dvEXT pglProgramUniform2dvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform3dvEXT(UInt32 program, Int32 location, Int32 count, double* value);

			[ThreadStatic]
			internal static glProgramUniform3dvEXT pglProgramUniform3dvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform4dvEXT(UInt32 program, Int32 location, Int32 count, double* value);

			[ThreadStatic]
			internal static glProgramUniform4dvEXT pglProgramUniform4dvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix2dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glProgramUniformMatrix2dvEXT pglProgramUniformMatrix2dvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix3dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glProgramUniformMatrix3dvEXT pglProgramUniformMatrix3dvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix4dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glProgramUniformMatrix4dvEXT pglProgramUniformMatrix4dvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix2x3dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glProgramUniformMatrix2x3dvEXT pglProgramUniformMatrix2x3dvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix2x4dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glProgramUniformMatrix2x4dvEXT pglProgramUniformMatrix2x4dvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix3x2dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glProgramUniformMatrix3x2dvEXT pglProgramUniformMatrix3x2dvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix3x4dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glProgramUniformMatrix3x4dvEXT pglProgramUniformMatrix3x4dvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix4x2dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glProgramUniformMatrix4x2dvEXT pglProgramUniformMatrix4x2dvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix4x3dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);

			[ThreadStatic]
			internal static glProgramUniformMatrix4x3dvEXT pglProgramUniformMatrix4x3dvEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureBufferRangeEXT(UInt32 texture, Int32 target, Int32 internalformat, UInt32 buffer, IntPtr offset, UInt32 size);

			[ThreadStatic]
			internal static glTextureBufferRangeEXT pglTextureBufferRangeEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureStorage1DEXT(UInt32 texture, Int32 target, Int32 levels, Int32 internalformat, Int32 width);

			[ThreadStatic]
			internal static glTextureStorage1DEXT pglTextureStorage1DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureStorage2DEXT(UInt32 texture, Int32 target, Int32 levels, Int32 internalformat, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glTextureStorage2DEXT pglTextureStorage2DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureStorage3DEXT(UInt32 texture, Int32 target, Int32 levels, Int32 internalformat, Int32 width, Int32 height, Int32 depth);

			[ThreadStatic]
			internal static glTextureStorage3DEXT pglTextureStorage3DEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureStorage2DMultisampleEXT(UInt32 texture, Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height, bool fixedsamplelocations);

			[ThreadStatic]
			internal static glTextureStorage2DMultisampleEXT pglTextureStorage2DMultisampleEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureStorage3DMultisampleEXT(UInt32 texture, Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);

			[ThreadStatic]
			internal static glTextureStorage3DMultisampleEXT pglTextureStorage3DMultisampleEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayBindVertexBufferEXT(UInt32 vaobj, UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride);

			[ThreadStatic]
			internal static glVertexArrayBindVertexBufferEXT pglVertexArrayBindVertexBufferEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexArrayVertexAttribFormatEXT(UInt32 vaobj, UInt32 attribindex, Int32 size, Int32 type, bool normalized, UInt32 relativeoffset);

			[ThreadStatic]
			internal static glVertexArrayVertexAttribFormatEXT pglVertexArrayVertexAttribFormatEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexArrayVertexAttribIFormatEXT(UInt32 vaobj, UInt32 attribindex, Int32 size, Int32 type, UInt32 relativeoffset);

			[ThreadStatic]
			internal static glVertexArrayVertexAttribIFormatEXT pglVertexArrayVertexAttribIFormatEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexArrayVertexAttribLFormatEXT(UInt32 vaobj, UInt32 attribindex, Int32 size, Int32 type, UInt32 relativeoffset);

			[ThreadStatic]
			internal static glVertexArrayVertexAttribLFormatEXT pglVertexArrayVertexAttribLFormatEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexArrayVertexAttribBindingEXT(UInt32 vaobj, UInt32 attribindex, UInt32 bindingindex);

			[ThreadStatic]
			internal static glVertexArrayVertexAttribBindingEXT pglVertexArrayVertexAttribBindingEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexArrayVertexBindingDivisorEXT(UInt32 vaobj, UInt32 bindingindex, UInt32 divisor);

			[ThreadStatic]
			internal static glVertexArrayVertexBindingDivisorEXT pglVertexArrayVertexBindingDivisorEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayVertexAttribLOffsetEXT(UInt32 vaobj, UInt32 buffer, UInt32 index, Int32 size, Int32 type, Int32 stride, IntPtr offset);

			[ThreadStatic]
			internal static glVertexArrayVertexAttribLOffsetEXT pglVertexArrayVertexAttribLOffsetEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexturePageCommitmentEXT(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, bool commit);

			[ThreadStatic]
			internal static glTexturePageCommitmentEXT pglTexturePageCommitmentEXT;

			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexArrayVertexAttribDivisorEXT(UInt32 vaobj, UInt32 index, UInt32 divisor);

			[ThreadStatic]
			internal static glVertexArrayVertexAttribDivisorEXT pglVertexArrayVertexAttribDivisorEXT;

		}
	}

}
