string? line;

int maxCalories = 0;
int totalCalories = 0;

while ((line = Console.ReadLine()) != null) {
  if (string.IsNullOrEmpty(line)) {
    totalCalories = 0;
    continue;
  }

  var calories = int.Parse(line);
  totalCalories += calories;

  if (totalCalories > maxCalories) {
    maxCalories = totalCalories;
  }
}

Console.WriteLine(maxCalories);
