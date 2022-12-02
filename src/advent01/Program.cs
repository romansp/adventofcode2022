static void PartOne() {
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
}

static void PartTwo() {
  string? line;

  int[] topThreeCalories = new int[3];
  int totalCalories = 0;

  while ((line = Console.ReadLine()) != null) {
    if (string.IsNullOrEmpty(line)) {
      if (totalCalories > topThreeCalories[0]) {
        topThreeCalories[0] = totalCalories;
        Array.Sort(topThreeCalories);
      }

      totalCalories = 0;
      continue;
    }

    var calories = int.Parse(line);
    totalCalories += calories;
  }

  Console.WriteLine(topThreeCalories.Sum());
}

PartTwo();
