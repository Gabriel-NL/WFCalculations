namespace WFCalculations
{
    public class ZawBuildClass
    {
        //Raw damage values
        public float impact_dmg = 0;
        public float puncture_dmg = 0;
        public float slash_dmg = 0;
        public float viral_dmg = 0;

        //Advanced damage values
        private double base_dmg = 0;
        private double modified_dmg { get; set; }


        //Modifiers
        public float atk_speed = 0;
        public double crit_chance = 0.0;
        public double crit_multiplier = 0;
        public int crit_tier = 0;
        public float status_chance = 0;
        public float reach = 0;
        public float riven_disposition = 0;

        //Components
        public string strike = "";
        public string grip = "";
        public string link = "";

        //Others
        public bool is_one_handed = false;
        public float dmg_bonus = 0;
        public float dmg_bonus_multiplier = 1;
        public string weapon_type = "";

        public ZawBuildClass(string strike, string grip, string link)
        {
            this.strike = strike;
            this.grip = grip;
            this.link = link;
            GripStats(grip);
            StrikeStats(strike);
            LinkStats(link);
            if (dmg_bonus != 0)
            {

                DistributeExtraDmg();
            }

            this.base_dmg = impact_dmg + puncture_dmg + slash_dmg + viral_dmg;

            this.modified_dmg = DetectOverCrit();


        }

        private void GripStats(string grip)
        {

            switch (grip)
            {
                case "Jayap":
                    is_one_handed = false;
                    dmg_bonus += 0;
                    atk_speed += 0.917f;
                    break;

                case "Korb":
                    is_one_handed = true;
                    dmg_bonus += 28;
                    atk_speed += 0.783f;
                    break;

                case "Kroostra":
                    is_one_handed = false;
                    dmg_bonus += 14;
                    atk_speed += 0.850f;
                    break;

                case "Kwath":
                    is_one_handed = true;
                    dmg_bonus += 14;
                    atk_speed += 0.850f;
                    break;

                case "Laka":
                    is_one_handed = true;
                    dmg_bonus += 0;
                    atk_speed += 0.917f;
                    break;

                case "Peye":
                    is_one_handed = true;
                    dmg_bonus -= 4;
                    atk_speed += 1.000f;
                    break;

                case "Seekalla":
                    is_one_handed = false;
                    dmg_bonus -= 4;
                    atk_speed += 1.000f;
                    break;

                case "Shtung":
                    is_one_handed = false;
                    dmg_bonus += 28;
                    atk_speed += 0.783f;
                    break;

                case "Plague Akwin":
                    is_one_handed = true;
                    dmg_bonus -= 2;
                    atk_speed += 0.950f;
                    break;

                case "Plague Bokwin":
                    is_one_handed = false;
                    dmg_bonus += 7;
                    atk_speed += 0.883f;
                    break;

                default:
                    break;
            }



        }

        private void StrikeStats(string strike)
        {

            switch (strike)
            {
                case "Balla":
                    if (is_one_handed)
                    {
                        weapon_type = "Dagger";
                        reach = 1.7f;
                    }
                    else
                    {
                        weapon_type = "Staff";
                        reach = 3f;
                        dmg_bonus_multiplier = 1;
                    }
                    impact_dmg = 11.2f;
                    puncture_dmg = 134.4f;
                    slash_dmg = 78.4f;
                    atk_speed += 0.083f;
                    crit_chance = 18;
                    crit_multiplier = 2;
                    status_chance = 18;
                    riven_disposition = 0.8f;
                    break;

                case "Cyath":
                    if (is_one_handed)
                    {
                        weapon_type = "Machete";
                        reach = 2.6f;
                    }
                    else
                    {
                        weapon_type = "Polearm";
                        reach = 3.0f;
                        dmg_bonus_multiplier = 1.08f;
                    }
                    impact_dmg = 46f;
                    puncture_dmg = 11.5f;
                    slash_dmg = 172.5f;
                    atk_speed += 0.0f;
                    crit_chance = 18;
                    crit_multiplier = 2;
                    status_chance = 18;
                    riven_disposition = 0.95f;
                    break;

                case "Dehtat":
                    if (is_one_handed)
                    {
                        weapon_type = "Rapier";
                        reach = 2.5f;
                    }
                    else
                    {
                        weapon_type = "Polearm";
                        reach = 3.0f;
                        dmg_bonus_multiplier = 1.09f;
                    }
                    impact_dmg = 22.4f;
                    puncture_dmg = 112.0f;
                    slash_dmg = 89.6f;
                    atk_speed += 0.083f;
                    crit_chance = 18;
                    crit_multiplier = 2;
                    status_chance = 18;
                    riven_disposition = 1.2f;
                    break;

                case "Dokrahm":
                    if (is_one_handed)
                    {
                        weapon_type = "Scythe";
                        reach = 1.7f;
                    }
                    else
                    {
                        weapon_type = "Heavy Blade";
                        reach = 3.0f;
                        dmg_bonus_multiplier = 0.93f;
                    }
                    impact_dmg = 46.4f;
                    puncture_dmg = 108.1f;
                    slash_dmg = 154.5f;
                    atk_speed += 0.083f;
                    crit_chance = 18;
                    crit_multiplier = 2;
                    status_chance = 18;
                    riven_disposition = 0.75f;
                    break;

                case "Kronsh":
                    if (is_one_handed)
                    {
                        weapon_type = "Machete";
                        reach = 2.6f;
                    }
                    else
                    {
                        weapon_type = "Polearm";
                        reach = 3.0f;
                        dmg_bonus_multiplier = 1.07f;
                    }
                    impact_dmg = 163.8f;
                    slash_dmg = 70.2f;
                    atk_speed -= 0.067f;
                    crit_chance = 18;
                    crit_multiplier = 2;
                    status_chance = 18;
                    riven_disposition = 1.3f;
                    break;

                case "Mewan":
                    if (is_one_handed)
                    {
                        weapon_type = "Sword";
                        reach = 2.5f;
                    }
                    else
                    {
                        weapon_type = "Polearm";
                        reach = 3.0f;
                        dmg_bonus_multiplier = 1.09f;
                    }
                    impact_dmg = 56.0f;
                    puncture_dmg = 78.4f;
                    slash_dmg = 89.6f;
                    atk_speed -= 0.067f;
                    crit_chance = 18;
                    crit_multiplier = 2;
                    status_chance = 18;
                    riven_disposition = 1.1f;
                    break;

                case "Ooltha":
                    if (is_one_handed)
                    {
                        weapon_type = "Sword";
                        reach = 2.5f;
                    }
                    else
                    {
                        weapon_type = "Staff";
                        reach = 3.0f;
                        dmg_bonus_multiplier = 1;
                    }
                    impact_dmg = 22.4f;
                    puncture_dmg = 89.6f;
                    slash_dmg = 112.0f;
                    atk_speed += 0.000f;
                    crit_chance = 18;
                    crit_multiplier = 2;
                    status_chance = 18;
                    riven_disposition = 1.25f;
                    break;

                case "Rabvee":
                    if (is_one_handed)
                    {
                        weapon_type = "Machete";
                        reach = 2.6f;
                    }
                    else
                    {
                        weapon_type = "Hammer";
                        reach = 3.0f;
                        dmg_bonus_multiplier = 1.08f;
                    }
                    impact_dmg = 140.4f;
                    puncture_dmg = 11.7f;
                    slash_dmg = 81.9f;
                    atk_speed -= 0.067f;
                    crit_chance = 18;
                    crit_multiplier = 2;
                    status_chance = 18;
                    riven_disposition = 1.3f;
                    break;

                case "Sepfahn":
                    if (is_one_handed)
                    {
                        weapon_type = "Nikana";
                        reach = 2.5f;
                    }
                    else
                    {
                        weapon_type = "Staff";
                        reach = 3.0f;
                        dmg_bonus_multiplier = 1;
                    }
                    impact_dmg = 22.6f;
                    puncture_dmg = 56.5f;
                    slash_dmg = 146.9f;
                    atk_speed += 0.000f;
                    crit_chance = 20;
                    crit_multiplier = 2;
                    status_chance = 20;
                    riven_disposition = 0.7f;
                    break;

                case "Plague Keewar":
                    if (is_one_handed)
                    {
                        weapon_type = "Scythe";
                        reach = 1.7f;
                    }
                    else
                    {
                        weapon_type = "Staff";
                        reach = 3.0f;
                        dmg_bonus_multiplier = 0.85f;
                    }
                    impact_dmg = 88.0f;
                    puncture_dmg = 57.0f;
                    slash_dmg = 91.0f;
                    viral_dmg = 70.0f;
                    atk_speed -= 0.033f;
                    crit_chance = 18;
                    crit_multiplier = 2;
                    status_chance = 22;
                    riven_disposition = 0.75f;
                    break;

                case "Plague Kripath":
                    if (is_one_handed)
                    {
                        weapon_type = "Rapier";
                        reach = 2.5f;
                    }
                    else
                    {
                        weapon_type = "Polearm";
                        reach = 3.0f;
                        dmg_bonus_multiplier = 1.08f;
                    }
                    impact_dmg = 30.0f;
                    puncture_dmg = 70.0f;
                    slash_dmg = 49.0f;
                    viral_dmg = 64.0f;
                    atk_speed += 0.033f;
                    crit_chance = 22;
                    crit_multiplier = 2.2f;
                    status_chance = 18;
                    riven_disposition = 0.6f;
                    break;

                default:
                    break;
            }
        }
        private void LinkStats(string link)
        {

            switch (link)
            {
                case "Jai":
                    atk_speed += 0.083f;
                    crit_chance += 0;
                    status_chance += 0;
                    dmg_bonus += -4;
                    break;

                case "Ruhang":
                    atk_speed += -0.067f;
                    crit_chance += 0;
                    status_chance += 0;
                    dmg_bonus += 14;
                    break;

                case "Jai II":
                    atk_speed += 0.167f;
                    crit_chance += 0;
                    status_chance += 0;
                    dmg_bonus += -8;
                    break;

                case "Ruhang II":
                    atk_speed -= 0.133f;
                    crit_chance += 0;
                    status_chance += 0;
                    dmg_bonus += 28;
                    break;

                case "Vargeet Jai":
                    atk_speed += 0.083f;
                    crit_chance += 7;
                    status_chance -= 4;
                    dmg_bonus += -4;
                    break;

                case "Vargeet Ruhang":
                    atk_speed += -0.067f;
                    crit_chance += 7;
                    status_chance -= 4;
                    dmg_bonus += 14;
                    break;

                case "Ekwana Jai":
                    atk_speed += 0.083f;
                    crit_chance -= 4;
                    status_chance += 7;
                    dmg_bonus += -4;
                    break;

                case "Ekwana Ruhang":
                    atk_speed += -0.067f;
                    crit_chance -= 4;
                    status_chance += 7;
                    dmg_bonus += 14;
                    break;

                case "Vargeet II Jai":
                    atk_speed += 0.083f;
                    crit_chance += 14;
                    status_chance -= 8;
                    dmg_bonus += -4;
                    break;

                case "Vargeet II Ruhang":
                    atk_speed += -0.067f;
                    crit_chance += 14;
                    status_chance -= 8;
                    dmg_bonus += 14;
                    break;

                case "Ekwana II Jai":
                    atk_speed += 0.083f;
                    crit_chance -= 8;
                    status_chance += 14;
                    dmg_bonus += -4;
                    break;

                case "Ekwana II Ruhang":
                    atk_speed += -0.067f;
                    crit_chance -= 8;
                    status_chance += 14;
                    dmg_bonus += 14;
                    break;

                case "Vargeet Jai II":
                    atk_speed += 0.167f;
                    crit_chance += 7;
                    status_chance -= 4;
                    dmg_bonus += -8;
                    break;

                case "Vargeet Ruhang II":
                    atk_speed += -0.133f;
                    crit_chance += 7;
                    status_chance -= 4;
                    dmg_bonus += 28;
                    break;

                case "Ekwana Jai II":
                    atk_speed += 0.167f;
                    crit_chance -= 4;
                    status_chance += 7;
                    dmg_bonus += -8;
                    break;

                case "Ekwana Ruhang II":
                    atk_speed += -0.133f;
                    crit_chance -= 4;
                    status_chance += 7;
                    dmg_bonus += 28;
                    break;


                default:
                    break;
            }
        }

        private void DistributeExtraDmg()
        {
            float temptotal = impact_dmg + puncture_dmg + slash_dmg + viral_dmg;

            float imp_share = impact_dmg / temptotal;
            impact_dmg += (imp_share * dmg_bonus);
            impact_dmg *= dmg_bonus_multiplier;

            float pun_share = puncture_dmg / temptotal;
            puncture_dmg += (pun_share * dmg_bonus);
            puncture_dmg *= dmg_bonus_multiplier;

            float sls_share = slash_dmg / temptotal;
            slash_dmg += (sls_share * dmg_bonus);
            slash_dmg *= dmg_bonus_multiplier;

            float vrl_share = viral_dmg / temptotal;
            viral_dmg += (vrl_share * dmg_bonus);
            viral_dmg *= dmg_bonus_multiplier;

        }

        public double DetectOverCrit()
        {
            if (crit_chance > 100)
            {
                crit_tier = (int)(crit_chance / 100f);
                crit_chance %= 100f;

                return Criting(base_dmg, crit_tier - 1);
            }
            else
            {
                return base_dmg;
            }

        }
        public double Criting(double base_dmg, double crit_tier)
        {
            double multiplier = crit_multiplier + ((crit_multiplier * crit_tier) - 1 * crit_tier);
            base_dmg = base_dmg * multiplier;
            return base_dmg;
        }

        public void ShowAdvancedStats()
        {
            Console.WriteLine($"{strike}/{grip}/{link}");

            Console.WriteLine($"Base dmg per hit={modified_dmg}");
            Console.WriteLine($"Crit dmg={Criting(base_dmg, crit_tier)}");

        }
        public double GetFinalDmg()
        {
            return modified_dmg;
        }

        public void ShowStats()
        {

            Console.WriteLine($"Weapon type={weapon_type}");
            Console.WriteLine($"Reach ={reach}");
            Console.WriteLine($"RD={riven_disposition}");

            Console.WriteLine($"{strike}/{grip}/{link}");

            Console.WriteLine($"Atk Speed={atk_speed}");
            Console.WriteLine($"Crit chance={crit_chance}%");
            Console.WriteLine($"Crit multiplier={crit_multiplier}x");
            Console.WriteLine($"Status chance={status_chance}%");

            Console.WriteLine($"Impact={Math.Round(impact_dmg, 3)} / Puncture={Math.Round(puncture_dmg, 1)} / Slash={Math.Round(slash_dmg, 1)} / Viral={Math.Round(viral_dmg, 1)}");
            Console.WriteLine($"Base dmg={base_dmg}");



        }


    }
}