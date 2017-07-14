#pragma once

#include "Node.h"
#include <deque>
#include <set>
#include <memory>

namespace Library
{
	class Graph;

	using NodePtr = std::shared_ptr<Node>;
	using HeuristicType = std::function<float(NodePtr, NodePtr)>;

	class IPathFinder
	{
	public:
		IPathFinder() {};
		IPathFinder(HeuristicType heuristic);
		virtual ~IPathFinder() { };
		virtual std::deque<NodePtr> FindPath(NodePtr start, NodePtr end, std::set<NodePtr>& closedSet) = 0;
		std::deque<NodePtr> FindPath(NodePtr start, NodePtr end);

		void SetHeuristicFunction(HeuristicType function);

	protected:
		HeuristicType mHeuristicFunction;
	};
}