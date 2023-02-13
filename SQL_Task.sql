Select Products.Name, Categories.Name
From Products Left Join ProductCategory
On Products.Id = ProductCategory.ProductId 
Left Join Categories
On Categories.Id = ProductCategory.CategoryId