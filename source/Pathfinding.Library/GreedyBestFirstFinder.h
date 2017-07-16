#pragma once
#include "IPathFinder.h"

namespace Library
{
	class GreedyBestFirstFinder final : public IPathFinder
	{
	public:

		GreedyBestFirstFinder(HeuristicFn_t heuristic);
		std::deque<NodePtr> FindPath(NodePtr start, NodePtr end, std::set<NodePtr>& closedSet) override;

		std::string GetName() const override;
	};
}