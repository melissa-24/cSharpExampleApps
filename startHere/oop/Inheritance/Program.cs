Garden Honeybee = new Garden("HoneyBee's Garden");
Garden Bronx = new Garden("The Botanical Garden");

Honeybee.GardenInfo();

Plant Thyme = new Plant("Thyme");
Plant Oregano = new Plant("Oregano");
Plant Strawberry = new Plant("Strawberry");
Plant Pumpkin = new Plant("Pumpkin");

Thyme.PrintPlantInfo();
Oregano.PrintPlantInfo();


Honeybee.AllPlants.Add(Thyme);
Bronx.AllPlants.Add(Pumpkin);
Honeybee.AllPlants.Add(Oregano);


Honeybee.ShowPlants();
Bronx.ShowPlants();

Honeybee.PlantOfTheDay();

// Strawberry.AddPlant(Strawberry, Honeybee);


Edible Basil = new Edible("Basil", "Annual Herb", "Weekly");
Edible Rosemary = new Edible("Rosemary", "Perennial Herb", "Monthly");

GroundCover FourOClocks = new GroundCover("4 O'clocks");
GroundCover Hasta = new GroundCover("Hasta");

Basil.AddPlant(Basil, Honeybee);
Rosemary.AddPlant(Rosemary, Honeybee);

Hasta.AddPlant(Hasta, Honeybee);

Hasta.SlowGrow();
Hasta.AddPlant(Hasta, Honeybee);