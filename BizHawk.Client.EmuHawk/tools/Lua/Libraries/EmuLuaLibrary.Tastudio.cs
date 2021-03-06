﻿using System;
using System.ComponentModel;

using BizHawk.Client.Common;
using LuaInterface;

namespace BizHawk.Client.EmuHawk
{
	[Description("A library for manipulating the Tastudio dialog of the EmuHawk client")]
	[LuaLibraryAttributes(released: true)]
	public sealed class TastudioLuaLibrary : LuaLibraryBase
	{
		public TastudioLuaLibrary(Lua lua)
			: base(lua) { }

		public TastudioLuaLibrary(Lua lua, Action<string> logOutputCallback)
			: base(lua, logOutputCallback) { }

		public override string Name { get { return "tastudio"; } }

		private TAStudio Tastudio
		{
			get
			{
				return GlobalWin.Tools.Get<TAStudio>() as TAStudio;
			}
		}


		[LuaMethodAttributes(
			"engaged",
			"returns whether or not tastudio is currently engaged (active)"
		)]
		public bool Engaged()
		{
			return GlobalWin.Tools.Has<TAStudio>(); // TODO: eventually tastudio should have an engaged flag
		}

		[LuaMethodAttributes(
			"getmarker",
			"returns the marker text at the given frame, or an empty string if there is no marker for the given frame"
		)]
		public string GetMarker(int frame)
		{
			if (Engaged())
			{
				var marker = Tastudio.CurrentTasMovie.Markers.Get(frame);
				if (marker != null)
				{
					return marker.Message;
				}
			}
			
			return string.Empty;
		}

		[LuaMethodAttributes(
			"removemarker",
			"if there is a marker for the given frame, it will be removed"
		)]
		public void RemoveMarker(int frame)
		{
			if (Engaged())
			{
				var marker = Tastudio.CurrentTasMovie.Markers.Get(frame);
				if (marker != null)
				{
					Tastudio.CurrentTasMovie.Markers.Remove(marker);
					Tastudio.UpdateValues();
				}
			}
		}

		[LuaMethodAttributes(
			"setmarker",
			"Adds or sets a marker at the given frame with the given message"
		)]
		public void SetMarker(int frame, string message)
		{
			if (Engaged())
			{
				var marker = Tastudio.CurrentTasMovie.Markers.Get(frame);
				if (marker != null)
				{
					marker.Message = message;
				}
				else
				{
					Tastudio.CurrentTasMovie.Markers.Add(frame, message);
					Tastudio.UpdateValues();
				}
			}
		}

		[LuaMethodAttributes(
			"islag",
			"Returns whether or not the given frame was a lag frame, null if unknown"
		)]
		public bool? IsLag(int frame)
		{
			if (Engaged())
			{
				if (frame < Tastudio.CurrentTasMovie.InputLogLength)
				{
					return Tastudio.CurrentTasMovie[frame].Lagged;
				}
			}

			return null;
		}

		[LuaMethodAttributes(
			"hasstate",
			"Returns whether or not the given frame has a savestate associated with it"
		)]
		public bool HasState(int frame)
		{
			if (Engaged())
			{
				if (frame < Tastudio.CurrentTasMovie.InputLogLength)
				{
					return Tastudio.CurrentTasMovie[frame].HasState;
				}
			}

			return false;
		}

		[LuaMethodAttributes(
			"onqueryitembg",
			"called during the background draw event of the tastudio listview"
		)]
		public void OnQueryItemBg(LuaFunction luaf)
		{
			if (Engaged())
			{
				Tastudio.QueryItemBgColorCallback = (int index, string name) =>
				{
					var result = luaf.Call(index, name);

					if (result != null)
					{
						var color = ToColor(result[0]);
						return color;
					}

					return null;
				};
			}
		}

		[LuaMethodAttributes(
			"onqueryitemtext",
			"called during the text draw event of the tastudio listview"
		)]
		public void OnQueryItemText(LuaFunction luaf)
		{
			if (Engaged())
			{
				Tastudio.QueryItemTextCallback = (int index, string name) =>
				{
					var result = luaf.Call(index, name);

					if (result != null)
					{
						if (result[0] != null)
						{
							return result[0].ToString();
						}
					}

					return (string)null;
				};
			}
		}

		[LuaMethodAttributes(
			"ongreenzoneinvalidated",
			"called whenever the greenzone is invalidated and returns the first frame that was invalidated"
		)]
		public void OnGreenzoneInvalidated(LuaFunction luaf)
		{
			if (Engaged())
			{
				Tastudio.GreenzoneInvalidatedCallback = (int index) =>
				{
					luaf.Call(index);
				};
			}
		}
	}
}
