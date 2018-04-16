// Copyright 2017, Sameek Kundu. All Rights Reserved. 

#pragma once

#include "ModuleManager.h"

class FMySQLModule : public IModuleInterface
{
public:

	/** IModuleInterface implementation */
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;
};