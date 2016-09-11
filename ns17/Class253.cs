using ns16;
using ns19;
using ns20;
using ns21;
using System;
using System.Collections.Generic;

namespace ns17
{
	public class Class253 : Class245
	{
		private Class318 class318_0;

		private bool bool_0;

		private bool bool_1;

		public Class253(Class318 class318_1, bool bool_2)
		{
			this.class318_0 = class318_1;
			this.bool_1 = bool_2;
		}

		public override void vmethod_0()
		{
			Console.WriteLine("-=- " + this.ToString() + " -=-");
			Class308 @class = this.class318_0.method_8("scripts\\guitar\\guitar_globaltags.qb");
			string[] array = new string[]
			{
				"Invo",
				"tma",
				"TomPudding",
				"MaXKilleR",
				"GameZelda"
			};
			string[] array2 = new string[]
			{
				"D. Stowater",
				"Ginkel",
				"Bunny",
				"BMarvs",
				"CVance"
			};
			string[] array3 = new string[]
			{
				"C. Ward",
				"Riggs",
				"davidicus",
				"B. Wiuff",
				"Pam D."
			};
			Class244.smethod_56(array);
			Console.WriteLine("Randomized Names:");
			int num = 0;
			while (num < 5 && !this.bool_0)
			{
				Console.WriteLine(array[num]);
				Class307 class2 = @class.method_5<Class307>(new Class307("name" + (num + 1)));
				if (class2.method_8().Equals(this.bool_1 ? array3[num] : array2[num]))
				{
					class2.method_9(array[num]);
				}
				else
				{
					this.bool_0 = true;
					Console.WriteLine("QB Database is already edited.");
				}
				num++;
			}
			if (!this.bool_0)
			{
				Class308 class3 = this.class318_0.method_8("scripts\\guitar\\guitar_memcard.qb");
				Console.WriteLine("Changing Save File Size to 5MB.");
				class3.method_5<Class299>(new Class299("fixed_size")).method_9(5242880);
				Console.WriteLine("Changing Save Folder Name.");
				class3.method_5<Class273>(new Class273("memcard_content_name")).method_8(string.Format("Progress{0}", (new string[]
				{
					"A",
					"B",
					"C",
					"D",
					"E",
					"F"
				})[new List<string>(new string[]
				{
					"qb",
					"qb_f",
					"qb_i",
					"qb_s",
					"qb_g",
					"qb_k"
				}).IndexOf(Class244.smethod_12(this.class318_0.string_0))]));
			}
			if (!this.bool_0)
			{
				Class308 class4 = this.class318_0.method_8("scripts\\guitar\\menu\\menu_setlist.qb");
				Console.WriteLine("Changing Setlist Scroller.");
				Class372.smethod_1(class4.method_5<Class274>(new Class274("setlist_scroll")));
				Console.WriteLine("Changing Tier Name Display.");
				Class372.smethod_1(class4.method_5<Class274>(new Class274("create_sl_assets")));
			}
			if (!this.bool_0)
			{
				Class308 class5 = this.class318_0.method_8("scripts\\guitar\\guitar.qb");
				class5.method_5<Class302>(new Class302("load_z_soundcheck")).method_5<Class307>(new Class307("title")).method_9("Sound Check");
				class5.method_5<Class302>(new Class302("load_z_credits")).method_5<Class307>(new Class307("title")).method_9("Guitar Hero Tower");
				class5.method_5<Class302>(new Class302("viewer")).method_5<Class307>(new Class307("title")).method_9("Black Background");
				class5.method_5<Class302>(new Class302("load_z_viewer")).method_5<Class307>(new Class307("title")).method_9("Black Background");
			}
		}

		public override string ToString()
		{
			return "Modify Default Data";
		}

		public override bool Equals(Class245 other)
		{
			return other is Class253;
		}
	}
}