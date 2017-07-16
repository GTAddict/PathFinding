#pragma once

#include "Node.h"
#include <deque>
#include <set>
#include <memory>

namespace Library
{
	class Graph;

	using NodePtr		= std::shared_ptr<Node>;
	using NodeWeakPtr	= std::weak_ptr<Node>;
	using HeuristicFn_t = std::function<float(NodePtr, NodePtr)>;
	using CostFn_t		= std::function<float(NodePtr, NodePtr)>;

	class IPathFinder
	{
	public:
		IPathFinder() {};
		IPathFinder(HeuristicFn_t heuristicFunction, CostFn_t costFunction);

		virtual ~IPathFinder() { };
		virtual std::deque<NodePtr> FindPath(NodePtr start, NodePtr end, std::set<NodePtr>& closedSet) = 0;
		std::deque<NodePtr> FindPath(NodePtr start, NodePtr end);

		void SetHeuristicFunction(HeuristicFn_t function);
		void SetCostFunction(CostFn_t function);

	protected:
		HeuristicFn_t mHeuristicFunction;
		CostFn_t mCostFunction;
	};
}