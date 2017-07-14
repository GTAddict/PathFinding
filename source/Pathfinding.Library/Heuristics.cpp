﻿#include "pch.h"
#include "Heuristics.h"

namespace Library
{
	float Heuristics::ManhattanDistance(std::shared_ptr<Node> current, std::shared_ptr<Node> end)
	{
		return static_cast<float>(abs(end->Location().X() - current->Location().X()) - abs(end->Location().Y() - current->Location().Y()));
	}
}