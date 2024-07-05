namespace WFCalculations
{
    public class ZawBuildClass
    {
        public WeaponDataModel built_weapon;

        //Components
        public string strike = "";
        public string grip = "";
        public string link = "";

        //Others
        public bool is_one_handed = false;
        public decimal dmg_bonus = 0;
        public decimal dmg_bonus_multiplier = 1;
        public string weapon_type = "";

        public ZawBuildClass(string strike, string grip, string link)
        {
            this.strike = strike;
            this.grip = grip;
            this.link = link;
            built_weapon = new WeaponDataModel();
            built_weapon.Name = $"Zaw {strike}-{grip}-{link}";
            built_weapon.Category = "Melee";
            built_weapon.Series = "Zaw";
            built_weapon.Components = new Dictionary<string, string>()
            {
                { "Strike", strike },
                { "Grip", grip },
                { "Link", link },
            };
            built_weapon.DamageTypes = new Dictionary<string, decimal>();
            GripStats(grip, built_weapon);
            StrikeStats(strike, built_weapon);
            LinkStats(link, built_weapon);
            if (dmg_bonus != 0)
            {
                DistributeExtraDmg(built_weapon);
            }
        }

        private void GripStats(string grip, WeaponDataModel weapon)
        {
            switch (grip)
            {
                case "Jayap":
                    is_one_handed = false;
                    weapon.AtkSpeed += 0.917m;
                    break;

                case "Korb":
                    is_one_handed = true;
                    dmg_bonus += 28;
                    weapon.AtkSpeed += 0.783m;
                    break;

                case "Kroostra":
                    is_one_handed = false;
                    dmg_bonus += 14;
                    weapon.AtkSpeed += 0.850m;
                    break;

                case "Kwath":
                    is_one_handed = true;
                    dmg_bonus += 14;
                    weapon.AtkSpeed += 0.850m;
                    break;

                case "Laka":
                    is_one_handed = true;
                    dmg_bonus += 0;
                    weapon.AtkSpeed += 0.917m;
                    break;

                case "Peye":
                    is_one_handed = true;
                    dmg_bonus -= 4;
                    weapon.AtkSpeed += 1.000m;
                    break;

                case "Seekalla":
                    is_one_handed = false;
                    dmg_bonus -= 4;
                    weapon.AtkSpeed += 1.000m;
                    break;

                case "Shtung":
                    is_one_handed = false;
                    dmg_bonus += 28;
                    weapon.AtkSpeed += 0.783m;
                    break;

                case "Plague Akwin":
                    is_one_handed = true;
                    dmg_bonus -= 2;
                    weapon.AtkSpeed += 0.950m;
                    break;

                case "Plague Bokwin":
                    is_one_handed = false;
                    dmg_bonus += 7;
                    weapon.AtkSpeed += 0.883m;
                    break;

                default:
                    break;
            }
        }

        private void StrikeStats(string strike, WeaponDataModel weapon)
        {
            switch (strike)
            {
                case "Balla":
                    if (is_one_handed)
                    {
                        weapon.Type = "Dagger";
                        weapon.Reach = 1.7m;
                    }
                    else
                    {
                        weapon.Type = "Staff";
                        weapon.Reach = 3m;
                        dmg_bonus_multiplier = 1;
                    }

                    weapon.DamageTypes.Add(Constants.ImpactDmg, 11.2m);
                    weapon.DamageTypes.Add(Constants.PunctureDmg, 134.4m);
                    weapon.DamageTypes.Add(Constants.SlashDmg, 78.4m);
                    weapon.AtkSpeed += 0.083m;
                    weapon.CritChance = 18;
                    weapon.CritMultiplier = 2;
                    weapon.StatusChance = 18;
                    weapon.RivenDisposition = 0.8m;
                    break;

                case "Cyath":
                    if (is_one_handed)
                    {
                        weapon_type = "Machete";
                        weapon.Reach = 2.6m;
                    }
                    else
                    {
                        weapon_type = "Polearm";
                        weapon.Reach = 3.0m;
                        dmg_bonus_multiplier = 1.08m;
                    }
                    weapon.DamageTypes.Add(Constants.ImpactDmg, 46m);
                    weapon.DamageTypes.Add(Constants.PunctureDmg, 11.5m);
                    weapon.DamageTypes.Add(Constants.SlashDmg, 172.5m);
                    weapon.AtkSpeed += 0.0m;
                    weapon.CritChance = 18;
                    weapon.CritMultiplier = 2;
                    weapon.StatusChance = 18;
                    weapon.RivenDisposition = 0.95m;
                    break;

                case "Dehtat":
                    if (is_one_handed)
                    {
                        weapon_type = "Rapier";
                        weapon.Reach = 2.5m;
                    }
                    else
                    {
                        weapon_type = "Polearm";
                        weapon.Reach = 3.0m;
                        dmg_bonus_multiplier = 1.09m;
                    }
                    weapon.DamageTypes.Add(Constants.ImpactDmg, 22.4m);
                    weapon.DamageTypes.Add(Constants.PunctureDmg, 112.0m);
                    weapon.DamageTypes.Add(Constants.SlashDmg, 89.6m);
                    weapon.AtkSpeed += 0.083m;
                    weapon.CritChance = 18;
                    weapon.CritMultiplier = 2;
                    weapon.StatusChance = 18;
                    weapon.RivenDisposition = 1.2m;
                    break;

                case "Dokrahm":
                    if (is_one_handed)
                    {
                        weapon_type = "Scythe";
                        weapon.Reach = 1.7m;
                    }
                    else
                    {
                        weapon_type = "Heavy Blade";
                        weapon.Reach = 3.0m;
                        dmg_bonus_multiplier = 0.93m;
                    }
                    weapon.DamageTypes.Add(Constants.ImpactDmg, 46.4m);
                    weapon.DamageTypes.Add(Constants.PunctureDmg, 108.1m);
                    weapon.DamageTypes.Add(Constants.SlashDmg, 154.5m);
                    weapon.AtkSpeed += 0.083m;
                    weapon.CritChance = 18;
                    weapon.CritMultiplier = 2;
                    weapon.StatusChance = 18;
                    weapon.RivenDisposition = 0.75m;
                    break;

                case "Kronsh":
                    if (is_one_handed)
                    {
                        weapon_type = "Machete";
                        weapon.Reach = 2.6m;
                    }
                    else
                    {
                        weapon_type = "Polearm";
                        weapon.Reach = 3.0m;
                        dmg_bonus_multiplier = 1.07m;
                    }
                    weapon.DamageTypes.Add(Constants.ImpactDmg, 163.8m);
                    weapon.DamageTypes.Add(Constants.SlashDmg, 70.2m);
                    weapon.AtkSpeed -= 0.067m;
                    weapon.CritChance = 18;
                    weapon.CritMultiplier = 2;
                    weapon.StatusChance = 18;
                    weapon.RivenDisposition = 1.3m;
                    break;

                case "Mewan":
                    if (is_one_handed)
                    {
                        weapon_type = "Sword";
                        weapon.Reach = 2.5m;
                    }
                    else
                    {
                        weapon_type = "Polearm";
                        weapon.Reach = 3.0m;
                        dmg_bonus_multiplier = 1.09m;
                    }
                    weapon.DamageTypes.Add(Constants.ImpactDmg, 56.0m);
                    weapon.DamageTypes.Add(Constants.PunctureDmg, 78.4m);
                    weapon.DamageTypes.Add(Constants.SlashDmg, 89.6m);
                    weapon.AtkSpeed -= 0.067m;
                    weapon.CritChance = 18;
                    weapon.CritMultiplier = 2;
                    weapon.StatusChance = 18;
                    weapon.RivenDisposition = 1.1m;
                    break;

                case "Ooltha":
                    if (is_one_handed)
                    {
                        weapon_type = "Sword";
                        weapon.Reach = 2.5m;
                    }
                    else
                    {
                        weapon_type = "Staff";
                        weapon.Reach = 3.0m;
                        dmg_bonus_multiplier = 1;
                    }
                    weapon.DamageTypes.Add(Constants.ImpactDmg, 22.4m);
                    weapon.DamageTypes.Add(Constants.PunctureDmg, 89.6m);
                    weapon.DamageTypes.Add(Constants.SlashDmg, 112.0m);
                    weapon.AtkSpeed += 0.000m;
                    weapon.CritChance = 18;
                    weapon.CritMultiplier = 2;
                    weapon.StatusChance = 18;
                    weapon.RivenDisposition = 1.25m;
                    break;

                case "Rabvee":
                    if (is_one_handed)
                    {
                        weapon_type = "Machete";
                        weapon.Reach = 2.6m;
                    }
                    else
                    {
                        weapon_type = "Hammer";
                        weapon.Reach = 3.0m;
                        dmg_bonus_multiplier = 1.08m;
                    }
                    weapon.DamageTypes.Add(Constants.ImpactDmg, 140.4m);
                    weapon.DamageTypes.Add(Constants.PunctureDmg, 11.7m);
                    weapon.DamageTypes.Add(Constants.SlashDmg, 81.9m);
                    weapon.AtkSpeed -= 0.067m;
                    weapon.CritChance = 18;
                    weapon.CritMultiplier = 2;
                    weapon.StatusChance = 18;
                    weapon.RivenDisposition = 1.3m;
                    break;

                case "Sepfahn":
                    if (is_one_handed)
                    {
                        weapon_type = "Nikana";
                        weapon.Reach = 2.5m;
                    }
                    else
                    {
                        weapon_type = "Staff";
                        weapon.Reach = 3.0m;
                        dmg_bonus_multiplier = 1;
                    }
                    weapon.DamageTypes.Add(Constants.ImpactDmg, 22.6m);
                    weapon.DamageTypes.Add(Constants.PunctureDmg, 56.5m);
                    weapon.DamageTypes.Add(Constants.SlashDmg, 146.9m);
                    weapon.AtkSpeed += 0.000m;
                    weapon.CritChance = 20;
                    weapon.CritMultiplier = 2;
                    weapon.StatusChance = 20;
                    weapon.RivenDisposition = 0.7m;
                    break;

                case "Plague Keewar":
                    if (is_one_handed)
                    {
                        weapon_type = "Scythe";
                        weapon.Reach = 1.7m;
                    }
                    else
                    {
                        weapon_type = "Staff";
                        weapon.Reach = 3.0m;
                        dmg_bonus_multiplier = 0.85m;
                    }
                    weapon.DamageTypes.Add(Constants.ImpactDmg, 88.0m);
                    weapon.DamageTypes.Add(Constants.PunctureDmg, 57.0m);
                    weapon.DamageTypes.Add(Constants.SlashDmg, 91.0m);
                    weapon.DamageTypes.Add(Constants.ViralDmg, 70.0m);
                    weapon.AtkSpeed -= 0.033m;
                    weapon.CritChance = 18;
                    weapon.CritMultiplier = 2;
                    weapon.StatusChance = 22;
                    weapon.RivenDisposition = 0.75m;
                    break;

                case "Plague Kripath":
                    if (is_one_handed)
                    {
                        weapon_type = "Rapier";
                        weapon.Reach = 2.5m;
                    }
                    else
                    {
                        weapon_type = "Polearm";
                        weapon.Reach = 3.0m;
                        dmg_bonus_multiplier = 1.08m;
                    }
                    weapon.DamageTypes.Add(Constants.ImpactDmg, 30.0m);
                    weapon.DamageTypes.Add(Constants.PunctureDmg, 70.0m);
                    weapon.DamageTypes.Add(Constants.SlashDmg, 49.0m);
                    weapon.DamageTypes.Add(Constants.ViralDmg, 64.0m);
                    weapon.AtkSpeed += 0.033m;
                    weapon.CritChance = 22;
                    weapon.CritMultiplier = 2.2m;
                    weapon.StatusChance = 18;
                    weapon.RivenDisposition = 0.6m;
                    break;

                default:
                    break;
            }
        }

        private void LinkStats(string link, WeaponDataModel weapon)
        {
            switch (link)
            {
                case "Jai":
                    weapon.AtkSpeed += 0.083m;
                    weapon.CritChance += 0;
                    weapon.StatusChance += 0;
                    dmg_bonus += -4;
                    break;

                case "Ruhang":
                    weapon.AtkSpeed += -0.067m;
                    weapon.CritChance += 0;
                    weapon.StatusChance += 0;
                    dmg_bonus += 14;
                    break;

                case "Jai II":
                    weapon.AtkSpeed += 0.167m;
                    weapon.CritChance += 0;
                    weapon.StatusChance += 0;
                    dmg_bonus += -8;
                    break;

                case "Ruhang II":
                    weapon.AtkSpeed -= 0.133m;
                    weapon.CritChance += 0;
                    weapon.StatusChance += 0;
                    dmg_bonus += 28;
                    break;

                case "Vargeet Jai":
                    weapon.AtkSpeed += 0.083m;
                    weapon.CritChance += 7;
                    weapon.StatusChance -= 4;
                    dmg_bonus += -4;
                    break;

                case "Vargeet Ruhang":
                    weapon.AtkSpeed += -0.067m;
                    weapon.CritChance += 7;
                    weapon.StatusChance -= 4;
                    dmg_bonus += 14;
                    break;

                case "Ekwana Jai":
                    weapon.AtkSpeed += 0.083m;
                    weapon.CritChance -= 4;
                    weapon.StatusChance += 7;
                    dmg_bonus += -4;
                    break;

                case "Ekwana Ruhang":
                    weapon.AtkSpeed += -0.067m;
                    weapon.CritChance -= 4;
                    weapon.StatusChance += 7;
                    dmg_bonus += 14;
                    break;

                case "Vargeet II Jai":
                    weapon.AtkSpeed += 0.083m;
                    weapon.CritChance += 14;
                    weapon.StatusChance -= 8;
                    dmg_bonus += -4;
                    break;

                case "Vargeet II Ruhang":
                    weapon.AtkSpeed += -0.067m;
                    weapon.CritChance += 14;
                    weapon.StatusChance -= 8;
                    dmg_bonus += 14;
                    break;

                case "Ekwana II Jai":
                    weapon.AtkSpeed += 0.083m;
                    weapon.CritChance -= 8;
                    weapon.StatusChance += 14;
                    dmg_bonus += -4;
                    break;

                case "Ekwana II Ruhang":
                    weapon.AtkSpeed += -0.067m;
                    weapon.CritChance -= 8;
                    weapon.StatusChance += 14;
                    dmg_bonus += 14;
                    break;

                case "Vargeet Jai II":
                    weapon.AtkSpeed += 0.167m;
                    weapon.CritChance += 7;
                    weapon.StatusChance -= 4;
                    dmg_bonus += -8;
                    break;

                case "Vargeet Ruhang II":
                    weapon.AtkSpeed += -0.133m;
                    weapon.CritChance += 7;
                    weapon.StatusChance -= 4;
                    dmg_bonus += 28;
                    break;

                case "Ekwana Jai II":
                    weapon.AtkSpeed += 0.167m;
                    weapon.CritChance -= 4;
                    weapon.StatusChance += 7;
                    dmg_bonus += -8;
                    break;

                case "Ekwana Ruhang II":
                    weapon.AtkSpeed += -0.133m;
                    weapon.CritChance -= 4;
                    weapon.StatusChance += 7;
                    dmg_bonus += 28;
                    break;

                default:
                    break;
            }
        }

        private void DistributeExtraDmg(WeaponDataModel weapon)
        {
            decimal totalDamage = weapon.DamageTypes.Sum(x => x.Value);

            foreach (KeyValuePair<string, decimal> kvp in weapon.DamageTypes)
            {
                decimal key_share = kvp.Value / totalDamage;
                weapon.DamageTypes[kvp.Key] += (key_share * dmg_bonus);
                weapon.DamageTypes[kvp.Key] *= dmg_bonus_multiplier;
            }
        }
    }
}
