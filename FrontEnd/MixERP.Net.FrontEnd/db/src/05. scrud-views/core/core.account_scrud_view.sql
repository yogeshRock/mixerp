CREATE VIEW core.account_scrud_view
AS
SELECT
    core.accounts.account_id,
    core.account_masters.account_master_code,
    core.accounts.account_number,
    core.accounts.external_code,
    core.accounts.account_name,
    core.accounts.confidential,
    core.accounts.description,
    core.accounts.sys_type,
    parent_account.account_number || ' (' || parent_account.account_name || ')' AS parent,
    core.has_child_accounts(core.accounts.account_id) AS has_child
FROM core.accounts
INNER JOIN core.account_masters
ON core.account_masters.account_master_id=core.accounts.account_master_id
LEFT JOIN core.accounts parent_account
ON parent_account.account_id=core.accounts.parent_account_id
WHERE NOT core.accounts.sys_type;