#pragma once

#include "IPathFinder.h"

namespace Library
{
	class AStarFinder : public IPathFinder
	{
	public:

		AStarFinder(HeuristicFn_t heuristicFunction, CostFn_t costFunction);
		virtual ~AStarFinder() override = default;

		std::deque<NodePtr> FindPath(NodePtr start, NodePtr end, std::set<NodePtr>& closedSet) override;
		std::string GetName() const override;
	};
}