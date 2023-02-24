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

