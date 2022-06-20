class GFG
{

	static int citiesNumber = 8;

	// final_path[] stores the final solution ie, the
	// path of the salesman.
	static int[] finalPath = new int[citiesNumber + 1];

	// visited[] keeps track of the already visited nodes
	// in a particular path
	static bool[] visited = new bool[citiesNumber];

	// Stores the final minimum weight of shortest tour.
	static int finalRes = int.MaxValue;

	// Function to copy temporary solution to
	// the final solution
	static void copyToFinal(int[] currentPath)
	{
		for (int i = 0; i < citiesNumber; i++)
			finalPath[i] = currentPath[i];
		finalPath[citiesNumber] = currentPath[0];
	}

	// Function to find the minimum edge cost
	// having an end at the vertex i
	static int firstMin(int[,] adj, int i)
	{
		int min = int.MaxValue;
		for (int k = 0; k < citiesNumber; k++)
			if (adj[i,k] < min && i != k)
				min = adj[i,k];
		return min;
	}

	// function to find the second minimum edge cost
	// having an end at the vertex i
	static int secondMin(int[,] adj, int i)
	{
		int first = int.MaxValue, second = int.MaxValue;
		for (int j = 0; j < citiesNumber; j++)
		{
			if (i == j)
				continue;

			if (adj[i,j] <= first)
			{
				second = first;
				first = adj[i,j];
			}
			else if (adj[i,j] <= second &&
					adj[i,j] != first)
				second = adj[i,j];
		}
		return second;
	}

	// function that takes as arguments:
	// curr_bound -> lower bound of the root node
	// curr_weight-> stores the weight of the path so far
	// level-> current level while moving in the search
	//		 space tree
	// curr_path[] -> where the solution is being stored which
	//			 would later be copied to final_path[]
	static void TSPRec(int[,] adj, int currentBound, int currentWeight,
				int level, int[] currentPath)
	{
		// base case is when we have reached level N which
		// means we have covered all the nodes once
		if (level == citiesNumber)
		{
			// check if there is an edge from last vertex in
			// path back to the first vertex
			if (adj[currentPath[level - 1],currentPath[0]] != 0)
			{
				// curr_res has the total weight of the
				// solution we got
				int curr_res = currentWeight +
						adj[currentPath[level - 1],currentPath[0]];

				// Update final result and final path if
				// current result is better.
				if (curr_res < finalRes)
				{
					copyToFinal(currentPath);
					finalRes = curr_res;
				}
			}
			return;
		}

		// for any other level iterate for all vertices to
		// build the search space tree recursively
		for (int i = 0; i < citiesNumber; i++)
		{
			// Consider next vertex if it is not same (diagonal
			// entry in adjacency matrix and not visited
			// already)
			if (adj[currentPath[level - 1],i] != 0 &&
					visited[i] == false)
			{
				int temp = currentBound;
				currentWeight += adj[currentPath[level - 1],i];

				// different computation of curr_bound for
				// level 2 from the other levels
				if (level == 1)
					currentBound -= ((firstMin(adj, currentPath[level - 1]) +
									firstMin(adj, i)) / 2);
				else
					currentBound -= ((secondMin(adj, currentPath[level - 1]) +
									firstMin(adj, i)) / 2);

				// curr_bound + curr_weight is the actual lower bound
				// for the node that we have arrived on
				// If current lower bound < final_res, we need to explore
				// the node further
				if (currentBound + currentWeight < finalRes)
				{
					currentPath[level] = i;
					visited[i] = true;

					// call TSPRec for the next level
					TSPRec(adj, currentBound, currentWeight, level + 1,	currentPath);
				}

				// Else we have to prune the node by resetting
				// all changes to curr_weight and curr_bound
				currentWeight -= adj[currentPath[level - 1],i];
				currentBound = temp;

				// Also reset the visited array
				// Arrays.fill(visited, false);
				visited = new bool[citiesNumber];
				for (int j = 0; j <= level - 1; j++)
					visited[currentPath[j]] = true;
			}
		}
	}

	// This function sets up final_path[]
	static void TSP(int[,] adj)
	{
		int[] currentPath = new int[citiesNumber + 1];

		// Calculate initial lower bound for the root node
		// using the formula 1/2 * (sum of first min +
		// second min) for all edges.
		// Also initialize the curr_path and visited array
		int currentBound = 0;
		for (int i = 0; i < currentPath.Length; i++)
			currentPath[i] = -1;
		visited = new bool[citiesNumber];

		// Compute initial bound
		for (int i = 0; i < citiesNumber; i++)
			currentBound += (firstMin(adj, i) +
						secondMin(adj, i));

		// Rounding off the lower bound to an integer
		currentBound = (currentBound == 1) ? currentBound / 2 + 1 :
									currentBound / 2;

		// We start at vertex 1 so the first vertex
		// in curr_path[] is 0
		visited[0] = true;
		currentPath[0] = 0;

		// Call to TSPRec for curr_weight equal to
		// 0 and level 1
		TSPRec(adj, currentBound, 0, 1, currentPath);
	}

	// Driver code
	public static void Main(String[] args)
	{
		//Adjacency matrix for the given graph
		int[,] adj = {
				   { -1, 10, 15, 8, 11, 5 , 8, 4},
				{ 10, -1, 35, 9, 18, 11, 3, 9 },
				{ 15, 35, -1, 5, 30, 12, 17, 20 },
				{ 10, 5, 15, -1, 25, 15, 13, 24 },
				{ 30, 20, 25, 15, -1, 11, 16, 4 },
				{ 20, 15, 18, 35, 19, -1, 17, 10 },
				{ 11, 14, 20, 26, 4, 22, -1, 18 },
				{ 3, 21, 12, 15, 30, 29, 7, -1 }
		};

		TSP(adj);

		Console.WriteLine($"Minimum cost : {finalRes}");
		Console.WriteLine("Path Taken : ");
		for (int i = 0; i <= citiesNumber; i++)
		{
			Console.WriteLine(finalPath[i]);
		}
	}
}