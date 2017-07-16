#include "pch.h"
#include "DijkstrasFinder.h"
#include "Heuristics.h"

namespace Library
{
	DijkstrasFinder::DijkstrasFinder(CostFn_t costFunction)
		: AStarFinder(nullptr, costFunction)
	{
	}

	std::string DijkstrasFinder::GetName() const
	{
		return std::string("Dijkstra's Search");
	}
}
