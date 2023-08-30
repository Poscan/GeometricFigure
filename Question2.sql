select p.name, c.name
  from Product p, Category c
 where exists (select 1
                 from Product_Category pc
                where pc.product_id = p.id
                  and pc.category_id = c.id)
    or not exists (select 1 from Product_Category pc where pc.product_id = p.id)
