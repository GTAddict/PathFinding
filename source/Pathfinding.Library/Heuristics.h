#pragma once
#include "Node.h"

namespace Library
{
	class Heuristics final
	{
	public:
		static float ManhattanDistance(std::shared_ptr<Node> current, std::shared_ptr<Node> end);
		static float ConstantOneDistance(std::shared_ptr<Node> node, std::shared_ptr<Node> neighbor);
	};
}