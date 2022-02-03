/*01 Potrebiteli*/
/*Ex1*/
SELECT id, username
FROM users
ORDER BY id;

/*Ex2*/
SELECT repository_id, contributor_id
FROM repositories_contributors
WHERE repository_id = contributor_id
ORDER BY repository_id;

/*Ex3*/
SELECT i.id,
	CONCAT((SELECT username 
		    FROM users 
            WHERE id = i.assignee_id) , " : " , i.title) AS "issue_assignee"
FROM issues AS i
ORDER BY i.id DESC;

/*Ex4*/
SELECT id, name AS "Name", CONCAT(size , "KB") AS size
FROM files
WHERE id NOT IN (SELECT DISTINCT parent_id FROM files WHERE parent_id IS NOT NULL)
ORDER BY id;

/*Ex5*/
SELECT r.id , r.name, (SELECT COUNT(i.id) 
				       FROM issues AS i 
                       WHERE repository_id = r.id) AS "issues"
FROM repositories AS r
ORDER BY issues DESC,r.id 
LIMIT 5;

/*Ex6*/
SELECT r.id, r.name, 
	(SELECT COUNT(c.id) 
	FROM commits AS c
	WHERE c.repository_id = r.id) AS "commits"
    ,
    (SELECT COUNT(rc.repository_id) 
     FROM repositories_contributors AS rc
     WHERE rc.repository_id = r.id) AS "contributors"
FROM repositories AS r
ORDER BY contributors DESC,r.id
LIMIT 1;

/*Ex7*/
SELECT r.id, r.name,COUNT(c.contributor_id)
FROM repositories AS r
LEFT JOIN(SELECT repository_id,contributor_id
		  FROM commits
          GROUP BY repository_id, contributor_id) AS c 
	ON c.repository_id = r.id
GROUP BY name
ORDER BY r.id, users DESC;


