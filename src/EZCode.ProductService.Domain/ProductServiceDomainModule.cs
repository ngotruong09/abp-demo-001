﻿using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace EZCode.ProductService;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(ProductServiceDomainSharedModule)
)]
public class ProductServiceDomainModule : AbpModule
{

}
