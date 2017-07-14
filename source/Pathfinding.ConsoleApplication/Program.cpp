#include "pch.h"

int main(int argc, char* argv[])
{
#if defined(DEBUG) | defined(_DEBUG)
	_CrtSetDbgFlag(_CRTDBG_ALLOC_MEM_DF | _CRTDBG_LEAK_CHECK_DF);
#endif

	UNREFERENCED_PARAMETER(argc);
	UNREFERENCED_PARAMETER(argv);

	using namespace Library;

	int32_t width, height;
	Graph g = GridHelper::LoadGridFromFile("Grid.grid", width, height);
	
	IPathFinder* finder = new GreedyBestFirstFinder(Heuristics::ManhattanDistance);
	std::deque<NodePtr> path = finder->FindPath(g.At(0, 0), g.At(width / 2, height - 1));
	std::set<NodePtr> collection;
	for (auto node : path)
	{
		collection.insert(node);
	}
	
	for (int32_t j = 0; j < height; ++j)
	{
		for (int32_t i = 0; i < width; ++i)
		{
			if (collection.find(g.At(i ,j)) != collection.end())
			{
				std::cout << "X ";
			}
			else
			{
				std::cout << static_cast<int32_t> (g.At(i, j)->Type()) << " ";
			}
		}

		std::cout << std::endl;
	}

	delete finder;

	system("pause");

	return 0;
}
