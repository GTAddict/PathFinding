#pragma once
#include "IPathFinder.h"

namespace Library
{
	class GreedyBestFirstFinder final : public IPathFinder
	{
	public:

		GreedyBestFirstFinder(HeuristicType heuristic);
		std::deque<NodePtr> FindPath(NodePtr start, NodePtr end, std::set<NodePtr>& closedSet) override;
	};
}