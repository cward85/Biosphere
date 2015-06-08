using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biosphere
{
    public class Constants
    {
        public const int STARTING_SUN = 10;
        public const int STARTING_INCOME = 10;      

        public const int STARTING_CARBON_COST = 10;
        public const double STARTING_CARBON_MULTIPLIER = .1;
        public const int STARTING_CARBON_BIOMASS = 10;
        public const double STARTING_CARBON_EVOLVE_CHANCE = .1;
        public const int STARTING_CARBON_INCOME = 1;

        public const int STARTING_OXYGEN_COST = 10;
        public const double STARTING_OXYGEN_MULTIPLIER = .1;
        public const int STARTING_OXYGEN_BIOMASS = 10;
        public const double STARTING_OXYGEN_EVOLVE_CHANCE = .1;
        public const int STARTING_OXYGEN_INCOME = 1;

        public const int STARTING_HYDROGEN_COST = 10;
        public const double STARTING_HYDROGEN_MULTIPLIER = .1;
        public const int STARTING_HYDROGEN_BIOMASS = 10;
        public const double STARTING_HYDROGEN_EVOLVE_CHANCE = .1;
        public const int STARTING_HYDROGEN_INCOME = 1;

        public const int STARTING_CO2_COST = 100;
        public const double STARTING_CO2_MULTIPLIER = .2;
        public const int STARTING_CO2_BIOMASS = 50;
        public const double STARTING_CO2_EVOLVE_CHANCE = .1;
        public const int STARTING_CO2_INCOME = 15;

        public const int STARTING_O2_COST = 100;
        public const double STARTING_O2_MULTIPLIER = .2;
        public const int STARTING_O2_BIOMASS = 50;
        public const double STARTING_O2_EVOLVE_CHANCE = .1;
        public const int STARTING_O2_INCOME = 15;

        public const int STARTING_O3_COST = 1000;
        public const double STARTING_O3_MULTIPLIER = .2;
        public const int STARTING_O3_BIOMASS = 10;
        public const double STARTING_O3_EVOLVE_CHANCE = .1;
        public const int STARTING_O3_INCOME = 1;

        public const int STARTING_H2O_COST = 100;
        public const double STARTING_H2O_MULTIPLIER = .2;
        public const int STARTING_H2O_BIOMASS = 50;
        public const double STARTING_H2O_EVOLVE_CHANCE = .1;
        public const int STARTING_H2O_INCOME = 15;

        public const int STARTING_ALGAE_COST = 100;
        public const double STARTING_ALGAE_MULTIPLIER = .2;
        public const int STARTING_ALGAE_BIOMASS = 100;
        public const double STARTING_ALGAE_EVOLVE_CHANCE = .1;
        public const int STARTING_ALGAE_INCOME = 60;

        public const int STARTING_SMALL_SEA_COST = 1000;
        public const double STARTING_SMALL_SEA_MULTIPLIER = .2;
        public const int STARTING_SMALL_SEA_BIOMASS = 250;
        public const double STARTING_SMALL_SEA_EVOLVE_CHANCE = .1;
        public const int STARTING_SMALL_SEA_INCOME = 150;

        public const int STARTING_OXYGEN_FACTORY_COST = 1000;
        public const double STARTING_OXYGEN_FACTORY_MULTIPLIER = .2;
        public const int STARTING_OXYGEN_FACTORY_BIOMASS = 500;
        public const double STARTING_OXYGEN_FACTORY_EVOLVE_CHANCE = .1;
        public const int STARTING_OXYGEN_FACTORY_INCOME = 10;

        public const int STARTING_CARBON_FACTORY_COST = 1000;
        public const double STARTING_CARBON_FACTORY_MULTIPLIER = .2;
        public const int STARTING_CARBON_FACTORY_BIOMASS = 500;
        public const double STARTING_CARBON_FACTORY_EVOLVE_CHANCE = .1;
        public const int STARTING_CARBON_FACTORY_INCOME = 10;

        public const int STARTING_HYDROGEN_FACTORY_COST = 1000;
        public const double STARTING_HYDROGEN_FACTORY_MULTIPLIER = .2;
        public const int STARTING_HYDROGEN_FACTORY_BIOMASS = 500;
        public const double STARTING_HYDROGEN_FACTORY_EVOLVE_CHANCE = .1;
        public const int STARTING_HYDROGEN_FACTORY_INCOME = 10;

    }

    public enum WorldObjectType
    {
        Oxygen,
        Hydrogen,
        Carbon,
        CarbonDioxide,
        OxygenMolecule,
        Ozone,
        Water,
        Algae,
        SmallSeaCreature,
        CarbonFactory,
        HydrogenFactory,
        OxygenFactory
    }
}
