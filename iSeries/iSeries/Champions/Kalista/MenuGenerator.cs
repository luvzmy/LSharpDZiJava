﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MenuGenerator.cs" company="LeagueSharp">
//   Copyright (C) 2015 LeagueSharp
//   
//             This program is free software: you can redistribute it and/or modify
//             it under the terms of the GNU General Public License as published by
//             the Free Software Foundation, either version 3 of the License, or
//             (at your option) any later version.
//   
//             This program is distributed in the hope that it will be useful,
//             but WITHOUT ANY WARRANTY; without even the implied warranty of
//             MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//             GNU General Public License for more details.
//   
//             You should have received a copy of the GNU General Public License
//             along with this program.  If not, see <http://www.gnu.org/licenses/>.
// </copyright>
// <summary>
//   The menu generator class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace iSeries.Champions.Kalista
{
    using LeagueSharp.Common;

    /// <summary>
    ///     The menu generator class.
    /// </summary>
    public static class MenuGenerator
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The generation function.
        /// </summary>
        /// <param name="root">
        ///     The root menu
        /// </param>
        public static void Generate(Menu root)
        {
            var targetSelectorMenu = new Menu("Target Selector", "Target Selector");
            TargetSelector.AddToMenu(targetSelectorMenu);
            root.AddSubMenu(targetSelectorMenu);

            Variables.Orbwalker = new Orbwalking.Orbwalker(root.AddSubMenu(new Menu("Orbwalking", "Orbwalking")));

            var comboMenu = new Menu("Combo Options", "com.iseries.kalista.combo");
            {
                comboMenu.AddItem(new MenuItem("com.iseries.kalista.combo.useQ", "Use Q").SetValue(true));
                comboMenu.AddItem(new MenuItem("com.iseries.kalista.combo.useE", "Use E").SetValue(true));
                root.AddSubMenu(comboMenu);
            }

            var harassMenu = new Menu("Harass Optionos", "com.iseries.kalista.harass");
            {
                harassMenu.AddItem(new MenuItem("com.iseries.kalista.harass.useQ", "Use Q").SetValue(false));
                harassMenu.AddItem(new MenuItem("com.iseries.kalista.harass.useE", "Use E").SetValue(false));
                harassMenu.AddItem(new MenuItem("com.iseries.kalista.harass.stacks", "E Stacks").SetValue(new Slider(5, 2, 10)));
                root.AddSubMenu(harassMenu);
            }

            var laneclearMenu = new Menu("Laneclear Options", "com.iseries.kalista.laneclear");
            {
                laneclearMenu.AddItem(new MenuItem("com.iseries.kalista.laneclear.useQ", "Use Q").SetValue(true));
                laneclearMenu.AddItem(
                    new MenuItem("com.iseries.kalista.laneclear.useQNum", "Q Number").SetValue(new Slider(4, 2, 10)));
                laneclearMenu.AddItem(new MenuItem("com.iseries.kalista.laneclear.useE", "Use E").SetValue(true));
                laneclearMenu.AddItem(
                    new MenuItem("com.iseries.kalista.laneclear.useENum", "E Number").SetValue(new Slider(4, 2, 10)));
                root.AddSubMenu(laneclearMenu);
            }

            var misc = new Menu("Misc Options", "com.iseries.kalista.misc");
            {
                misc.AddItem(new MenuItem("com.iseries.kalista.misc.mobsteal", "Jungle Steal").SetValue(true));
                misc.AddItem(new MenuItem("com.iseries.kalista.misc.lasthit", "Last Hit Assist").SetValue(true));
                root.AddSubMenu(misc);
            }
        }

        #endregion
    }
}